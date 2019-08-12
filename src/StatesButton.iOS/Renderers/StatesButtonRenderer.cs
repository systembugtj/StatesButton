using System;
using System.Reflection;
using System.Threading.Tasks;
using StatesButton.Forms;
using StatesButton.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using StatesButton.Shared;
using CoreGraphics;
using Xamarin.Forms.Internals;

[assembly: ExportRenderer(typeof(StatesButtonControl), typeof(StatesButtonRenderer))]
namespace StatesButton.iOS.Renderers
{
    [Preserve(AllMembers = true)]
    public class StatesButtonRenderer : ButtonRenderer
    {
        public static new void Init()
        {
            var date = DateTime.Now;
        }

        public StatesButtonControl BaseElement => Element as StatesButtonControl;

        protected async override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                Control.ShowsTouchWhenHighlighted = false;
                Control.AdjustsImageWhenHighlighted = false;
                await SetNormalImageResource();
                await SetDisableImageResource();
                await SetPressImageResource();
                if (e.NewElement is StatesButtonControl statesButton && statesButton.BackgroundColor != Color.Default && statesButton.PressedBackgroundColor != Color.Default && statesButton.DisableBackgroundColor != Color.Default)
                {
                    Control.ShowsTouchWhenHighlighted = false;
                    SetNormalColorResource();
                    SetDisableColorResource();
                    SetPressColorResource();
                }
            }
        }

        protected override UIButton CreateNativeControl() => new UIButton(UIButtonType.Custom);

        protected async override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == StatesButtonControl.NormalImageProperty.PropertyName)
            {
                await SetNormalImageResource();
            }
            else if (e.PropertyName == StatesButtonControl.DisableImageProperty.PropertyName)
            {
                await SetDisableImageResource();
            }
            else if (e.PropertyName == StatesButtonControl.PressedImageProperty.PropertyName)
            {
                await SetPressImageResource();
            }
            else if (e.PropertyName == VisualElement.BackgroundColorProperty.PropertyName)
            {
                SetNormalColorResource();
            }
            else if (e.PropertyName == StatesButtonControl.DisableBackgroundColorProperty.PropertyName)
            {
                SetDisableColorResource();
            }
            else if (e.PropertyName == StatesButtonControl.PressedBackgroundColorProperty.PropertyName)
            {
                SetPressColorResource();
            }
        }

        #region Color Impl

        protected virtual void SetNormalColorResource()
        {
            UIImage source = null;
            if (BaseElement.BackgroundColor != Color.Default)
            {
                source = ImageFromColor(BaseElement.BackgroundColor.ToUIColor());
            }
            Control.SetBackgroundImage(source, UIControlState.Normal);
        }

        protected virtual void SetDisableColorResource()
        {
            UIImage source = null;
            if (BaseElement.BackgroundColor != Color.Default)
            {
                source = ImageFromColor(BaseElement.DisableBackgroundColor.ToUIColor());
            }
            Control.SetBackgroundImage(source, UIControlState.Disabled);
        }

        protected virtual void SetPressColorResource()
        {
            UIImage source = null;
            if (BaseElement.BackgroundColor != Color.Default)
            {
                source = ImageFromColor(BaseElement.PressedBackgroundColor.ToUIColor());
            }
            Control.ShowsTouchWhenHighlighted = false;
            Control.SetBackgroundImage(source, UIControlState.Selected);
            Control.SetBackgroundImage(source, UIControlState.Highlighted);
        }

        protected virtual UIImage ImageFromColor(UIColor color)
        {
            CGRect rect = new CGRect(0.0f, 0.0f, 1.0f, 1.0f);
            UIGraphics.BeginImageContext(rect.Size);
            CGContext context = UIGraphics.GetCurrentContext();
            context.SetFillColor(color.CGColor);
            context.FillRect(rect);
            UIImage image = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();
            return image;
        }

        #endregion

        #region Image Impl

        protected virtual async Task SetNormalImageResource()
        {
            UIImage source = null;
            if (BaseElement.NormalImage != null)
            {
                var handler = BaseElement.NormalImage.GetHandler();
                source = await handler.LoadImageAsync(BaseElement.NormalImage);
            }
            Control.SetBackgroundImage(source, UIControlState.Normal);
        }

        protected virtual async Task SetDisableImageResource()
        {
            UIImage source = null;
            if (BaseElement.DisableImage != null)
            {
                var handler = BaseElement.DisableImage.GetHandler();
                source = await handler.LoadImageAsync(BaseElement.DisableImage);
            }
            Control.SetBackgroundImage(source, UIControlState.Disabled);
        }

        protected virtual async Task SetPressImageResource()
        {
            UIImage source = null;
            if (BaseElement.PressedImage != null)
            {
                var handler = BaseElement.PressedImage.GetHandler();
                source = await handler.LoadImageAsync(BaseElement.PressedImage);
                Control.ShowsTouchWhenHighlighted = false;
            }

            if (source == null)
            {
                Control.ShowsTouchWhenHighlighted = true;
            }
            Control.SetBackgroundImage(source, UIControlState.Selected);
            Control.SetBackgroundImage(source, UIControlState.Highlighted);
        }

        #endregion
    }
}