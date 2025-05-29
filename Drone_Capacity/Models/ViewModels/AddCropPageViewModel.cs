using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Maui.Views;
using Drone_Capacity.Views;
using Microsoft.Maui.Controls;

namespace Drone_Capacity.Models.ViewModels
{
    public class AddCropPageViewModel
    {
        // Command for navigation of MyFields page to Home Button (the back button)
        public ICommand BackToHomepageCommand { get; }

        public ICommand ShowPopupAddCropCommand { get; }
        public ICommand CropTappedCommand { get; }

        public AddCropPageViewModel() {
            // Initialize the command to navigate to Home Page
            BackToHomepageCommand = new Command(async () => await NavigateBack());

            ShowPopupAddCropCommand = new Command(async () => await OnShowPopup());
            CropTappedCommand = new Command(async () => await MyFieldsPage2Command());
        }

        private async Task NavigateBack()
        {
            await Shell.Current.GoToAsync("//Home");
        }

        private async Task OnShowPopup()
        {
            await Shell.Current.ShowPopupAsync(new Views.AddCropPagePopup());
        }

        private async Task MyFieldsPage2Command()
        {
            await Shell.Current.GoToAsync("//MyFields2");
        }
    }
}
