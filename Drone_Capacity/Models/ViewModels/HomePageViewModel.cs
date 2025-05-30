using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Drone_Capacity.Models.ViewModels
{
    public class HomePageViewModel
    {
        // Command for navigation of Home page to AddCrop UI
        public ICommand AddCropCommand { get; }

        // Command for navigation of Home page to MyFields UI
        public ICommand HomeToMyFieldsCommand { get; }

        // Command for navigation to the Diagnose Disease UI
        public ICommand FeatureOneCommand { get; }

        // Command for navigation in the Consultant UI
        public ICommand FeatureFifthCommand { get; }


        public HomePageViewModel()
        {
            // Initialize the command to navigate to MyFields
            AddCropCommand = new Command(async () => await NavigateToAddCrop());
            HomeToMyFieldsCommand = new Command(async () => await NavigateToMyFields());
            FeatureOneCommand = new Command(async () => await NavigateToDiagnoseDisease());
            FeatureFifthCommand = new Command(async () => await NavigateToConsultant());

        }

        // Navigate to Add Crop
        private async Task NavigateToAddCrop()
        {
            await Shell.Current.GoToAsync("//AddCrop");
        }

        // Navigate to MyFields
        private async Task NavigateToMyFields()
        {
            await Shell.Current.GoToAsync("//MyFields");
        }

        // Navigate to the Consultant UI
        private async Task NavigateToConsultant()
        {
            await Shell.Current.GoToAsync("//Consultant");
        }

        // Navigate to the Diagnose Disease UI
        private async Task NavigateToDiagnoseDisease()
        {
            await Shell.Current.GoToAsync("//DiagnoseDisease");
        }
    }
}
