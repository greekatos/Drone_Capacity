namespace Drone_Capacity.Views;
using Drone_Capacity.Models.ViewModels;
using Microsoft.Maui.Controls;

public partial class AddCropPage : ContentPage
{
    public AddCropPage()
    {
        InitializeComponent();
        BindingContext = new AddCropPageViewModel();
    }
}

