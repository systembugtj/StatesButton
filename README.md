#StatesButton
States Button Control for Xamarin.Forms

##Setup

###iOS

In your AppDelegate add this:

```
StatesButtonRenderer.Init();
```

###Android

In your MainActivity add this:

```
StatesButtonRenderer.Init();
```

##Usage

Images background states

```
var myButton = new StatesButtonControl () {
				Text = "Hello",
				NormalImage = "button",
				DisableImage = "button_disabled",
				PressedImage = "button_press",
				TextColor = Color.White
			};
```

Color background states

```
var myButton = new StatesButtonControl () {
				Text = "Hello",
				BackgroundColor = Color.Red,
				DisableBackgroundColor = Color.Blue,
				PressedBackgroundColor = Color.Fuchsia,
				TextColor = Color.White
			};
```

# Nuget
* Nuget Package (https://www.nuget.org/packages/StatesButton.Forms)
