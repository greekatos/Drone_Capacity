namespace Drone_Capacity.Views;
using Drone_Capacity.Models.ViewModels;
using Microsoft.Maui.Controls;

public partial class DiagnoseDiseasePage : ContentPage
{
	public DiagnoseDiseasePage()
	{
		InitializeComponent();
		BindingContext = new DiagnoseDiseaseViewModel();
	}
}