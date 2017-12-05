using System;
using Xamarin.Forms;

namespace StatesButton.Forms
{
    public class StatesButtonControl : Button
    {
        public static readonly BindableProperty DisableBackgroundColorProperty = BindableProperty.Create(nameof(DisableBackgroundColor), typeof(Color), typeof(StatesButtonControl), Color.Default, BindingMode.OneWay, null, null, null, null);
        public static readonly BindableProperty PressedBackgroundColorProperty = BindableProperty.Create(nameof(PressedBackgroundColor), typeof(Color), typeof(StatesButtonControl), Color.Default, BindingMode.OneWay, null, null, null, null);
        public static readonly BindableProperty NormalImageProperty = BindableProperty.Create(nameof(NormalImage), typeof(ImageSource), typeof(StatesButtonControl), null, BindingMode.OneWay, null, null, null, null);
        public static readonly BindableProperty DisableImageProperty = BindableProperty.Create(nameof(DisableImage), typeof(ImageSource), typeof(StatesButtonControl), null, BindingMode.OneWay, null, null, null, null);
        public static readonly BindableProperty PressedImageProperty = BindableProperty.Create(nameof(PressedImage), typeof(ImageSource), typeof(StatesButtonControl), null, BindingMode.OneWay, null, null, null, null);

        #region Color Impl

        public Color DisableBackgroundColor
        {
            get => (Color)GetValue(DisableBackgroundColorProperty);
            set => SetValue(DisableBackgroundColorProperty, value);
        }

        public Color PressedBackgroundColor
        {
            get => (Color)GetValue(PressedBackgroundColorProperty);
            set => SetValue(PressedBackgroundColorProperty, value);
        }

        #endregion

        #region Image Impl

        public ImageSource NormalImage
        {
            get => (ImageSource)GetValue(NormalImageProperty);
            set => SetValue(NormalImageProperty, value);
        }

        public ImageSource DisableImage
        {
            get => (ImageSource)GetValue(DisableImageProperty);
            set => SetValue(DisableImageProperty, value);
        }

        public ImageSource PressedImage
        {
            get => (ImageSource)GetValue(PressedImageProperty);
            set => SetValue(PressedImageProperty, value);
        }

        #endregion
    }
}