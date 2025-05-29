using Drone_Capacity.Models.ViewModels;

namespace Drone_Capacity.Views;

public partial class MyFieldsPage2 : ContentPage
{
	public MyFieldsPage2()
	{
		InitializeComponent();
        BindingContext = new MyFieldsPageViewModel2();
    }
}