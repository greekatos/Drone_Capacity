using Drone_Capacity.Models.ViewModels;

namespace Drone_Capacity.Views;

public partial class MyFieldsPage : ContentPage
{
	public MyFieldsPage()
	{
		InitializeComponent();
        BindingContext = new MyFieldsPageViewModel();
    }
}