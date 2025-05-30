using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Drone_Capacity.Models.ViewModels
{
    internal class ReportDiseaseGenerationViewModel
    {
        // Command for  navigation to the Live Camera Feed page 
        public ICommand NavigateBackToLiveCameraFeedCommand { get; }

        public ReportDiseaseGenerationViewModel()
        {
            NavigateBackToLiveCameraFeedCommand = new Command(async () => await NavigateBackToLiveCameraFeed());
        }

        private async Task NavigateBackToLiveCameraFeed()
        {
            await Shell.Current.GoToAsync("//DiagnoseDiseaseLiveCameraFeed");
        }
    }
}
