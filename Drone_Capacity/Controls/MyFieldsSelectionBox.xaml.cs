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
    }
}