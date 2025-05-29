namespace Drone_Capacity.Views;
using Drone_Capacity.Models.ViewModels;
using Microsoft.Maui.Controls;

public partial class ConsultantPage : ContentPage
{
	public ConsultantPage()
	{
		InitializeComponent();
		BindingContext = new ConsultantPageViewModel();
	}
}