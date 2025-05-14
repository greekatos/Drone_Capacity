using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using System.Windows.Input;


namespace Drone_Capacity.Controls
{
    public partial class CustomCompositeControl : ContentView
    {
        public CustomCompositeControl()
        {
            InitializeComponent();
        }

        // 1) Background rectangle
        public static readonly BindableProperty RectangleBackgroundColorProperty =
            BindableProperty.Create(nameof(RectangleBackgroundColor), typeof(Color), typeof(CustomCompositeControl), Colors.LightGray);
        public Color RectangleBackgroundColor
        {
            get => (Color)GetValue(RectangleBackgroundColorProperty);
            set => SetValue(RectangleBackgroundColorProperty, value);
        }

        public static readonly BindableProperty RectangleHeightProperty =
            BindableProperty.Create(nameof(RectangleHeight), typeof(double), typeof(CustomCompositeControl), 200.0);
        public double RectangleHeight
        {
            get => (double)GetValue(RectangleHeightProperty);
            set => SetValue(RectangleHeightProperty, value);
        }

        public static readonly BindableProperty RectangleWidthProperty =
            BindableProperty.Create(nameof(RectangleWidth), typeof(double), typeof(CustomCompositeControl), 160.0);
        public double RectangleWidth
        {
            get => (double)GetValue(RectangleWidthProperty);
            set => SetValue(RectangleWidthProperty, value);
        }

        // 2) Top image
        public static readonly BindableProperty TopImageSourceProperty =
            BindableProperty.Create(nameof(TopImageSource), typeof(ImageSource), typeof(CustomCompositeControl), default(ImageSource));
        public ImageSource TopImageSource
        {
            get => (ImageSource)GetValue(TopImageSourceProperty);
            set => SetValue(TopImageSourceProperty, value);
        }

        public static readonly BindableProperty TopImageHeightProperty =
            BindableProperty.Create(nameof(TopImageHeight), typeof(double), typeof(CustomCompositeControl), 60.0);
        public double TopImageHeight
        {
            get => (double)GetValue(TopImageHeightProperty);
            set => SetValue(TopImageHeightProperty, value);
        }

        // 3) Label underneath
        public static readonly BindableProperty TopLabelTextProperty =
            BindableProperty.Create(nameof(TopLabelText), typeof(string), typeof(CustomCompositeControl), string.Empty);
        public string TopLabelText
        {
            get => (string)GetValue(TopLabelTextProperty);
            set => SetValue(TopLabelTextProperty, value);
        }

        public static readonly BindableProperty TopLabelTextColorProperty =
            BindableProperty.Create(nameof(TopLabelTextColor), typeof(Color), typeof(CustomCompositeControl), Colors.Black);
        public Color TopLabelTextColor
        {
            get => (Color)GetValue(TopLabelTextColorProperty);
            set => SetValue(TopLabelTextColorProperty, value);
        }

        public static readonly BindableProperty TopLabelFontSizeProperty =
            BindableProperty.Create(nameof(TopLabelFontSize), typeof(double), typeof(CustomCompositeControl), 16.0);
        public double TopLabelFontSize
        {
            get => (double)GetValue(TopLabelFontSizeProperty);
            set => SetValue(TopLabelFontSizeProperty, value);
        }

        // 4) Bottom button
        public static readonly BindableProperty BottomButtonTextProperty =
            BindableProperty.Create(nameof(BottomButtonText), typeof(string), typeof(CustomCompositeControl), string.Empty);
        public string BottomButtonText
        {
            get => (string)GetValue(BottomButtonTextProperty);
            set => SetValue(BottomButtonTextProperty, value);
        }

        public static readonly BindableProperty BottomLeftImageSourceProperty =
            BindableProperty.Create(nameof(BottomLeftImageSource), typeof(ImageSource), typeof(CustomCompositeControl), default(ImageSource));
        public ImageSource BottomLeftImageSource
        {
            get => (ImageSource)GetValue(BottomLeftImageSourceProperty);
            set => SetValue(BottomLeftImageSourceProperty, value);
        }

        public static readonly BindableProperty BottomRightImageSourceProperty =
            BindableProperty.Create(nameof(BottomRightImageSource), typeof(ImageSource), typeof(CustomCompositeControl), default(ImageSource));
        public ImageSource BottomRightImageSource
        {
            get => (ImageSource)GetValue(BottomRightImageSourceProperty);
            set => SetValue(BottomRightImageSourceProperty, value);
        }

        public static readonly BindableProperty BottomButtonCommandProperty =
            BindableProperty.Create(nameof(BottomButtonCommand), typeof(ICommand), typeof(CustomCompositeControl), null);
        public ICommand BottomButtonCommand
        {
            get => (ICommand)GetValue(BottomButtonCommandProperty);
            set => SetValue(BottomButtonCommandProperty, value);
        }

        public static readonly BindableProperty BottomButtonBackgroundColorProperty =
            BindableProperty.Create(nameof(BottomButtonBackgroundColor), typeof(Color), typeof(CustomCompositeControl), Colors.LightGray);
        public Color BottomButtonBackgroundColor
        {
            get => (Color)GetValue(BottomButtonBackgroundColorProperty);
            set => SetValue(BottomButtonBackgroundColorProperty, value);
        }

        public static readonly BindableProperty BottomButtonTextColorProperty =
            BindableProperty.Create(nameof(BottomButtonTextColor), typeof(Color), typeof(CustomCompositeControl), Colors.Black);
        public Color BottomButtonTextColor
        {
            get => (Color)GetValue(BottomButtonTextColorProperty);
            set => SetValue(BottomButtonTextColorProperty, value);
        }

        public static readonly BindableProperty BottomButtonFontSizeProperty =
            BindableProperty.Create(nameof(BottomButtonFontSize), typeof(double), typeof(CustomCompositeControl), 14.0);
        public double BottomButtonFontSize
        {
            get => (double)GetValue(BottomButtonFontSizeProperty);
            set => SetValue(BottomButtonFontSizeProperty, value);
        }

        // Height of the button in the bottom
        public static readonly BindableProperty BottomButtonHeightProperty =
            BindableProperty.Create(nameof(BottomButtonHeight), typeof(double), typeof(CustomCompositeControl), 40.0);

        public double BottomButtonHeight
        {
            get => (double)GetValue(BottomButtonHeightProperty);
            set => SetValue(BottomButtonHeightProperty, value);
        }

        // Width of the button in the bottom
        public static readonly BindableProperty BottomButtonWidthProperty =
            BindableProperty.Create(nameof(BottomButtonWidth), typeof(double), typeof(CustomCompositeControl), 120.0);

        public double BottomButtonWidth
        {
            get => (double)GetValue(BottomButtonWidthProperty);
            set => SetValue(BottomButtonWidthProperty, value);
        }
    }
}

