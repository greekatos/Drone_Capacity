using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;

namespace Drone_Capacity.Controls
{
    public partial class CustomBorderButton : ContentView
    {
        public CustomBorderButton()
        {
            InitializeComponent();

            // Set a default stroke shape with rounded corners (if not provided)
            StrokeShape = new RoundRectangle { CornerRadius = 10 };
        }

        // Bindable property for ButtonText
        public static readonly BindableProperty ButtonTextProperty = 
            BindableProperty.Create(nameof(ButtonText), typeof(string), typeof(CustomBorderButton), default(string));

        public string ButtonText
        {
            get => (string)GetValue(ButtonTextProperty);
            set => SetValue(ButtonTextProperty, value);
        }

        // Bindable property for LeftImageSource
        public static readonly BindableProperty LeftImageSourceProperty =
            BindableProperty.Create(nameof(LeftImageSource), typeof(ImageSource), typeof(CustomBorderButton), default(ImageSource));

        public ImageSource LeftImageSource
        {
            get => (ImageSource)GetValue(LeftImageSourceProperty);
            set => SetValue(LeftImageSourceProperty, value);
        }

        // Bindable property for RightImageSource
        public static readonly BindableProperty RightImageSourceProperty =
            BindableProperty.Create(nameof(RightImageSource), typeof(ImageSource), typeof(CustomBorderButton), default(ImageSource));

        public ImageSource RightImageSource
        {
            get => (ImageSource)GetValue(RightImageSourceProperty);
            set => SetValue(RightImageSourceProperty, value);
        }

        // Bindable property for TextColor
        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(CustomBorderButton), Colors.White);

        public Color TextColor
        {
            get => (Color)GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }

        // Bindable property for FontSize
        public static readonly BindableProperty FontSizeProperty =
            BindableProperty.Create(nameof(FontSize), typeof(double), typeof(CustomBorderButton), 18d);

        public double FontSize
        {
            get => (double)GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }

        // Bindable property for BackgroundColor
        // Note: ContentView already has a BackgroundColor property
        // You can choose to use that or create a new one if you wish.
        public static readonly BindableProperty StrokeShapeProperty =
            BindableProperty.Create(nameof(StrokeShape), typeof(Shape), typeof(CustomBorderButton), default(Shape));

        public Shape StrokeShape
        {
            get => (Shape)GetValue(StrokeShapeProperty);
            set => SetValue(StrokeShapeProperty, value);
        }

        // Bindable property for LeftImageHeight
        public static readonly BindableProperty LeftImageHeightProperty =
            BindableProperty.Create(nameof(LeftImageHeight), typeof(double), typeof(CustomBorderButton), 24d);

        public double LeftImageHeight
        {
            get => (double)GetValue(LeftImageHeightProperty);
            set => SetValue(LeftImageHeightProperty, value);
        }

        // Bindable property for RightImageHeight
        public static readonly BindableProperty RightImageHeightProperty =
            BindableProperty.Create(nameof(RightImageHeight), typeof(double), typeof(CustomBorderButton), 24d);

        public double RightImageHeight
        {
            get => (double)GetValue(RightImageHeightProperty);
            set => SetValue(RightImageHeightProperty, value);
        }

        // Bindable property for Command (to handle tap gestures)
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(Command), typeof(CustomBorderButton), default(Command));

        public Command Command
        {
            get => (Command)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }
    }
}