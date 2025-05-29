using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Drone_Capacity.Models.ViewModels
{
    class MyFieldsPageViewModel2
    {
        // Command for navigation of MyFields page to Home Button (the back button)
        public ICommand BackToAddCropCommand { get; }

        public MyFieldsPageViewModel2()
        {
            BackToAddCropCommand = new Command(async () => await NavigateBack());
        }

        private async Task NavigateBack()
        {
            await Shell.Current.GoToAsync("//AddCrop");
        }
    }
}
