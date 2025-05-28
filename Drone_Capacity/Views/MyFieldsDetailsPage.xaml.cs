using Drone_Capacity.Models.ViewModels;
namespace Drone_Capacity.Views;

public partial class MyFieldsDetailsPage : ContentPage
{
	public MyFieldsDetailsPage()
	{
		InitializeComponent();
		BindingContext = new MyFieldsDetailsPageViewModel();
	}
}