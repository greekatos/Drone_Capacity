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
    public class AddCropFormPageViewModel
    {
        // Command for navigation of MyFields page to Home Button (the back button)
        public ICommand BackToMyFields2 { get; }

        public AddCropFormPageViewModel()
        {
            BackToMyFields2 = new Command(async () => await NavigateBack());
        }

        private async Task NavigateBack()
        {
            await Shell.Current.GoToAsync("//MyFields2");
        }
    }
}
