namespace Drone_Capacity.Views;
using Drone_Capacity.Models.ViewModels;
using Microsoft.Maui.Controls;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        BindingContext = new HomePageViewModel();
    }
}