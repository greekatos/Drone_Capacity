using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using System.Windows.Input;

namespace Drone_Capacity.Controls
{
	public partial class FieldValues : ContentView
	{
        public FieldValues()
        {
            InitializeComponent();
        }

        // 1) Title
        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(nameof(Title), typeof(string), typeof(MyFieldsSelectionBox), string.Empty);
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        // 2) SeverityStatus
        public static readonly BindableProperty SeverityStatusProperty =
            BindableProperty.Create(nameof(SeverityStatus), typeof(string), typeof(MyFieldsSelectionBox), string.Empty);
        public string SeverityStatus
        {
            get => (string)GetValue(SeverityStatusProperty);
            set => SetValue(SeverityStatusProperty, value);
        }

        // 3) PercentageStatus
        public static readonly BindableProperty PercentageStatusProperty =
            BindableProperty.Create(nameof(PercentageStatus), typeof(string), typeof(MyFieldsSelectionBox), string.Empty);
        public string PercentageStatus
        {
            get => (string)GetValue(PercentageStatusProperty);
            set => SetValue(PercentageStatusProperty, value);
        }

        // 4) Crop image
        public static readonly BindableProperty ArrowImageSourceProperty =
            BindableProperty.Create(nameof(ArrowImageSource), typeof(ImageSource), typeof(MyFieldsSelectionBox), default(ImageSource));
        public ImageSource ArrowImageSource
        {
            get => (ImageSource)GetValue(ArrowImageSourceProperty);
            set => SetValue(ArrowImageSourceProperty, value);
        }
    }

}

	
