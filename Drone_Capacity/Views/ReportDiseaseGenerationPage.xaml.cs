namespace Drone_Capacity.Views;
using Drone_Capacity.Models.ViewModels;
using Microsoft.Maui.Controls;
public partial class ReportDiseaseGenerationPage : ContentPage
{
	public ReportDiseaseGenerationPage()
	{
		InitializeComponent();
		BindingContext = new ReportDiseaseGenerationViewModel();
	}
}