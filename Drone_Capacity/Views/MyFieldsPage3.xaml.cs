using Drone_Capacity.Models.ViewModels;

namespace Drone_Capacity.Views;

public partial class MyFieldsPage3 : ContentPage
{
	public MyFieldsPage3()
	{
		InitializeComponent();
        BindingContext = new MyFieldsPageViewModel3();
    }
}