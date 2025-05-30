using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Drone_Capacity.Models.ViewModels
{
    public class MyFieldsPageViewModel3
    {
        // Command for navigation of MyFields page to Home Button (the back button)
        public ICommand BackDiagnoseDiseaseCommand { get; }

        public MyFieldsPageViewModel3()
        {
            BackDiagnoseDiseaseCommand = new Command(async () => await NavigateBack());
        }

        private async Task NavigateBack()
        {
            await Shell.Current.GoToAsync("//DiagnoseDisease");
        }
    }
}
