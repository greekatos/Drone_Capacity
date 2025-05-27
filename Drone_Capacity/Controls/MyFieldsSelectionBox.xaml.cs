using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using System.Windows.Input;


namespace Drone_Capacity.Controls
{
    public partial class MyFieldsSelectionBox : ContentView
    {
        public MyFieldsSelectionBox()
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

        // 2) Crop image
        public static readonly BindableProperty CropImageSourceProperty =
            BindableProperty.Create(nameof(CropImageSource), typeof(ImageSource), typeof(MyFieldsSelectionBox), default(ImageSource));
        public ImageSource CropImageSource
        {
            get => (ImageSource)GetValue(CropImageSourceProperty);
            set => SetValue(CropImageSourceProperty, value);
        }

        // 3) Crop name
        public static readonly BindableProperty CropNameProperty =
            BindableProperty.Create(nameof(CropName), typeof(string), typeof(MyFieldsSelectionBox), string.Empty);
        public string CropName
        {
            get => (string)GetValue(CropNameProperty);
            set => SetValue(CropNameProperty, value);
        }

        // 4) Background Color
        public static readonly BindableProperty BackGroundColorProperty =
            BindableProperty.Create(nameof(BackGroundColorCode), typeof(string), typeof(MyFieldsSelectionBox), string.Empty);
        public string BackGroundColorCode
        {
            get => (string)GetValue(BackGroundColorProperty);
            set => SetValue(BackGroundColorProperty, value);
        }

        // 5) Text Color 1
        public static readonly BindableProperty TextColoroneProperty =
            BindableProperty.Create(nameof(TextColorone), typeof(string), typeof(MyFieldsSelectionBox), string.Empty);
        public string TextColorone
        {
            get => (string)GetValue(TextColoroneProperty);
            set => SetValue(TextColoroneProperty, value);
        }

        // 5) Text Color 2
        public static readonly BindableProperty TextColortwoProperty =
            BindableProperty.Create(nameof(TextColortwo), typeof(string), typeof(MyFieldsSelectionBox), string.Empty);
        public string TextColortwo
        {
            get => (string)GetValue(TextColortwoProperty);
            set => SetValue(TextColortwoProperty, value);
        }

        // GPS icon
        public static readonly BindableProperty GpsImageSourceProperty =
            BindableProperty.Create(nameof(GpsImageSource), typeof(ImageSource), typeof(MyFieldsSelectionBox), default(ImageSource));
        public ImageSource GpsImageSource
        {
            get => (ImageSource)GetValue(GpsImageSourceProperty);
            set => SetValue(GpsImageSourceProperty, value);
        }

        // Location text
        public static readonly BindableProperty LocationProperty =
            BindableProperty.Create(nameof(Location), typeof(string), typeof(MyFieldsSelectionBox), string.Empty);
        public string Location
        {
            get => (string)GetValue(LocationProperty);
            set => SetValue(LocationProperty, value);
        }

        // this get called when any instance is tapped
        async void OnBoxTapped(object sender, EventArgs e)
        {
            // navigate to your interactive map
            await Shell.Current.GoToAsync("//InteractiveMapPage");
        }

        // 4) Make a bindable ICommand that your page VM can set
        public static readonly BindableProperty TappedCommandProperty =
            BindableProperty.Create(
                nameof(TappedCommand),
                typeof(ICommand),
                typeof(MyFieldsSelectionBox),
                null);

        public ICommand TappedCommand
        {
            get => (ICommand)GetValue(TappedCommandProperty);
            set => SetValue(TappedCommandProperty, value);
        }

        // 5) A flag so you can turn taps on/off
        public static readonly BindableProperty IsTappableProperty =
            BindableProperty.Create(
                nameof(IsTappable),
                typeof(bool),
                typeof(MyFieldsSelectionBox),
                true);

        public bool IsTappable
        {
            get => (bool)GetValue(IsTappableProperty);
            set => SetValue(IsTappableProperty, value);
        }
    }
}