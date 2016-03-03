using System;
using Xamarin.Forms;

namespace StatesButton.Forms
{
	public class StatesButtonControl :Button
	{
		public StatesButtonControl ()
		{

		}

		#region Color Impl

		public static readonly BindableProperty DisableBackgroundColorProperty =
			BindableProperty.Create("DisableBackgroundColor", typeof(Color), typeof(StatesButtonControl), Color.Default, BindingMode.OneWay, null, null, null, null);

		public Color DisableBackgroundColor
		{
			get {
				return (Color)GetValue(DisableBackgroundColorProperty);
			}
			set {
				SetValue(DisableBackgroundColorProperty, value);
			}
		}

		public static readonly BindableProperty PressedBackgroundColorProperty =
			BindableProperty.Create("PressedBackgroundColor", typeof(Color), typeof(StatesButtonControl), Color.Default, BindingMode.OneWay, null, null, null, null);

		public Color PressedBackgroundColor
		{
			get {
				return (Color)GetValue(PressedBackgroundColorProperty);
			}
			set {
				SetValue(PressedBackgroundColorProperty, value);
			}
		}

		#endregion

		#region Image Impl

		public static readonly BindableProperty NormalImageProperty =
			BindableProperty.Create("NormalImage", typeof(ImageSource), typeof(StatesButtonControl), null, BindingMode.OneWay, null, null, null, null);

		public ImageSource NormalImage
		{
			get {
				return (ImageSource)GetValue(NormalImageProperty);
			}
			set {
				SetValue(NormalImageProperty, value);
			}
		}

		public static readonly BindableProperty DisableImageProperty =
			BindableProperty.Create("DisableImage", typeof(ImageSource), typeof(StatesButtonControl), null, BindingMode.OneWay, null, null, null, null);

		public ImageSource DisableImage
		{
			get {
				return (ImageSource)GetValue(DisableImageProperty);
			}
			set {
				SetValue(DisableImageProperty, value);
			}
		}

		public static readonly BindableProperty PressedImageProperty =
			BindableProperty.Create("PressedImage", typeof(ImageSource), typeof(StatesButtonControl), null, BindingMode.OneWay, null, null, null, null);

		public ImageSource PressedImage
		{
			get {
				return (ImageSource)GetValue(PressedImageProperty);
			}
			set {
				SetValue(PressedImageProperty, value);
			}
		}

		#endregion
	}
}