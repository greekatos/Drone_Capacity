using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using System.Windows.Input;

namespace Drone_Capacity.Controls
{
	public partial class DiagnoseDiseaseCustomControl : ContentView
	{
		public DiagnoseDiseaseCustomControl()
		{ 
			InitializeComponent();
		}

        // 1) Rectangle Height
        public static readonly BindableProperty RectangleHeightProperty =
            BindableProperty.Create(nameof(RectangleHeight), typeof(double), typeof(DiagnoseDiseaseCustomControl), 200.0);
        public double RectangleHeight
        {
            get => (double)GetValue(RectangleHeightProperty);
            set => SetValue(RectangleHeightProperty, value);
        }

        // 2) Rectangle Width
        public static readonly BindableProperty RectangleWidthProperty =
            BindableProperty.Create(nameof(RectangleWidth), typeof(double), typeof(DiagnoseDiseaseCustomControl), 200.0);
        public double RectangleWidth
        {
            get => (double)GetValue(RectangleWidthProperty);
            set => SetValue(RectangleWidthProperty, value);
        }

        // 3) Background rectangle
        public static readonly BindableProperty RectangleBackgroundColorProperty =
            BindableProperty.Create(nameof(RectangleBorderColor), typeof(Color), typeof(DiagnoseDiseaseCustomControl), Colors.LightGray);
        public Color RectangleBorderColor
        {
            get => (Color)GetValue(RectangleBackgroundColorProperty);
            set => SetValue(RectangleBackgroundColorProperty, value);
        }

        // 4) Label underneath
        public static readonly BindableProperty ImageSourceUrlProperty =
            BindableProperty.Create(nameof(ImageSourceUrl), typeof(string), typeof(DiagnoseDiseaseCustomControl), string.Empty);
        public string ImageSourceUrl
        {
            get => (string)GetValue(ImageSourceUrlProperty);
            set => SetValue(ImageSourceUrlProperty, value);
        }

        // 5) Title text
        public static readonly BindableProperty TitleTextProperty =
            BindableProperty.Create(nameof(TitleText), typeof(string), typeof(DiagnoseDiseaseCustomControl), string.Empty);
        public string TitleText
        {
            get => (string)GetValue(TitleTextProperty);
            set => SetValue(TitleTextProperty, value);
        }

        // 6) Subtitle text
        public static readonly BindableProperty SubtitleTextProperty =
            BindableProperty.Create(nameof(SubtitleText), typeof(string), typeof(DiagnoseDiseaseCustomControl), string.Empty);
        public string SubtitleText
        {
            get => (string)GetValue(SubtitleTextProperty);
            set => SetValue(SubtitleTextProperty, value);
        }

        // 14) Bottom button
        public static readonly BindableProperty BottomButtonTextProperty =
            BindableProperty.Create(nameof(BottomButtonText), typeof(string), typeof(DiagnoseDiseaseCustomControl), string.Empty);
        public string BottomButtonText
        {
            get => (string)GetValue(BottomButtonTextProperty);
            set => SetValue(BottomButtonTextProperty, value);
        }

        public static readonly BindableProperty BottomLeftImageSourceProperty =
            BindableProperty.Create(nameof(BottomLeftImageSource), typeof(ImageSource), typeof(DiagnoseDiseaseCustomControl), default(ImageSource));
        public ImageSource BottomLeftImageSource
        {
            get => (ImageSource)GetValue(BottomLeftImageSourceProperty);
            set => SetValue(BottomLeftImageSourceProperty, value);
        }

        public static readonly BindableProperty BottomRightImageSourceProperty =
            BindableProperty.Create(nameof(BottomRightImageSource), typeof(ImageSource), typeof(DiagnoseDiseaseCustomControl), default(ImageSource));
        public ImageSource BottomRightImageSource
        {
            get => (ImageSource)GetValue(BottomRightImageSourceProperty);
            set => SetValue(BottomRightImageSourceProperty, value);
        }

        public static readonly BindableProperty BottomButtonCommandProperty =
            BindableProperty.Create(nameof(BottomButtonCommand), typeof(ICommand), typeof(DiagnoseDiseaseCustomControl), null);
        public ICommand BottomButtonCommand
        {
            get => (ICommand)GetValue(BottomButtonCommandProperty);
            set => SetValue(BottomButtonCommandProperty, value);
        }

        public static readonly BindableProperty BottomButtonBackgroundColorProperty =
            BindableProperty.Create(nameof(BottomButtonBackgroundColor), typeof(Color), typeof(DiagnoseDiseaseCustomControl), Colors.LightGray);
        public Color BottomButtonBackgroundColor
        {
            get => (Color)GetValue(BottomButtonBackgroundColorProperty);
            set => SetValue(BottomButtonBackgroundColorProperty, value);
        }

        public static readonly BindableProperty BottomButtonTextColorProperty =
            BindableProperty.Create(nameof(BottomButtonTextColor), typeof(Color), typeof(DiagnoseDiseaseCustomControl), Colors.Black);
        public Color BottomButtonTextColor
        {
            get => (Color)GetValue(BottomButtonTextColorProperty);
            set => SetValue(BottomButtonTextColorProperty, value);
        }

        public static readonly BindableProperty BottomButtonFontSizeProperty =
            BindableProperty.Create(nameof(BottomButtonFontSize), typeof(double), typeof(DiagnoseDiseaseCustomControl), 14.0);
        public double BottomButtonFontSize
        {
            get => (double)GetValue(BottomButtonFontSizeProperty);
            set => SetValue(BottomButtonFontSizeProperty, value);
        }

        // Height of the button in the bottom
        public static readonly BindableProperty BottomButtonHeightProperty =
            BindableProperty.Create(nameof(BottomButtonHeight), typeof(double), typeof(DiagnoseDiseaseCustomControl), 40.0);

        public double BottomButtonHeight
        {
            get => (double)GetValue(BottomButtonHeightProperty);
            set => SetValue(BottomButtonHeightProperty, value);
        }

        // Width of the button in the bottom
        public static readonly BindableProperty BottomButtonWidthProperty =
            BindableProperty.Create(nameof(BottomButtonWidth), typeof(double), typeof(DiagnoseDiseaseCustomControl), 120.0);

        public double BottomButtonWidth
        {
            get => (double)GetValue(BottomButtonWidthProperty);
            set => SetValue(BottomButtonWidthProperty, value);
        }
    }

}
