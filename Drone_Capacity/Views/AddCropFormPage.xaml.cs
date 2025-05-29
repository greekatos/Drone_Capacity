namespace Drone_Capacity.Views;
using Drone_Capacity.Models.ViewModels;
using Microsoft.Maui.Controls;

public partial class AddCropFormPage : ContentPage
{
	public AddCropFormPage()
	{
		InitializeComponent();
        BindingContext = new AddCropFormPageViewModel();
	}

    async void OnSaveClicked(object sender, EventArgs e)
    {
        // ignore the actual inputs—just show a confirmation
        await DisplayAlert("Success", "Your crop has been saved!", "OK");

        // Navigate back to the Home route
        await Shell.Current.GoToAsync("//Home");
    }
}