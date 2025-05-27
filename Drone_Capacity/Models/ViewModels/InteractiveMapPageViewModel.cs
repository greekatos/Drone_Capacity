using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Drone_Capacity.Models.ViewModels
{
    class InteractiveMapPageViewModel
    {
        // Return the the MyFields UI
        public ICommand BackCommand { get; }
        // Return to the Home UI
        public ICommand CloseCommand { get; }
        // Go to the MyFields details
        public ICommand MyFieldsDetailsCommand { get; }

        public InteractiveMapPageViewModel()
        {
            BackCommand = new Command(async () => await NavigateToMyFields());
            CloseCommand = new Command(async () => await NavigateToHome());
            MyFieldsDetailsCommand = new Command(async () => await NavigateToMyFieldsDetails());
        }

        // Navigate to My Fields UI
        private async Task NavigateToMyFields()
        {
            await Shell.Current.GoToAsync("//MyFields");
        }

        // Navigate to Home UI
        private async Task NavigateToHome()
        {
            await Shell.Current.GoToAsync("//Home");
        }

        // Navigate to the MyFields UI
        private async Task NavigateToMyFieldsDetails()
        {
            await Shell.Current.GoToAsync("//MyFieldsDetails");
        }
    }
}
