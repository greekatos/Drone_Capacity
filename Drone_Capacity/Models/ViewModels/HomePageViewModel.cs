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
        // Command for navigation of Home page to myfields UI
        public ICommand HomeToMyFieldsCommand { get; }

        public HomePageViewModel()
        {
            // Initialize the command to navigate to MyFields
            HomeToMyFieldsCommand = new Command(async () => await NavigateToMyFields());
        }

        private async Task NavigateToMyFields()
        {
            await Shell.Current.GoToAsync("//MyFields");
        }
    }
}
