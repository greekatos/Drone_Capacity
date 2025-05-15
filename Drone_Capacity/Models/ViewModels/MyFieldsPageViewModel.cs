using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Drone_Capacity.Models.ViewModels
{
    class MyFieldsPageViewModel
    {
        // Command for navigation of MyFields page to Home Button (the back button)
        public ICommand BackToHomepageCommand { get; }

        public MyFieldsPageViewModel()
        {
            // Initialize the command to navigate to Home Page
            BackToHomepageCommand = new Command(async () => await NavigateBack());
        }

        private async Task NavigateBack()
        {
            await Shell.Current.GoToAsync("//Home");
        }
    }
}
