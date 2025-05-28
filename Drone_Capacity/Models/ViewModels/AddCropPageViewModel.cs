using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Drone_Capacity.Models.ViewModels
{
    public class AddCropPageViewModel
    {
        // Command for navigation of MyFields page to Home Button (the back button)
        public ICommand BackToHomepageCommand { get; }

        public ICommand AddTappedCommand { get; }

        // Tapping on any crop—name passed via CommandParameter
        public ICommand CropTappedCommand { get; }

        public AddCropPageViewModel() {
            // Initialize the command to navigate to Home Page
            BackToHomepageCommand = new Command(async () => await NavigateBack());
        }

        private async Task NavigateBack()
        {
            await Shell.Current.GoToAsync("//Home");
        }

        private Task ShowCropForm(string cropName = null)
        {
            // Example: passing the cropName as a query parameter
            if (!string.IsNullOrEmpty(cropName))
                return Shell.Current.GoToAsync($"CropFormPage?crop={cropName}");

            return Shell.Current.GoToAsync("CropFormPage");
        }
    }
}
