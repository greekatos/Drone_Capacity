using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Drone_Capacity.Models.ViewModels
{
    public class DiagnoseDiseaseViewModel
    {
        // Navigate back to the Home page UI
        public ICommand NavigateToHomePageCommand { get; }

        public ICommand DiagnoseCommand { get; }

        public DiagnoseDiseaseViewModel()
        {
            NavigateToHomePageCommand = new Command(async () => await NavigateToHomePage());
            DiagnoseCommand = new Command(async () => await NavigateToMyFields3Page());
        }

        // Navigate to Add Crop
        private async Task NavigateToHomePage()
        {
            await Shell.Current.GoToAsync("//Home");
        }

        // Navigate to MyFields 3
        private async Task NavigateToMyFields3Page()
        {
            await Shell.Current.GoToAsync("//MyFields3");
        }
    }
}
