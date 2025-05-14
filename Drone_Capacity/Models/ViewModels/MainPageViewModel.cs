using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace Drone_Capacity.Models.ViewModels
{
    public class MainPageViewModel
    {
        // Wait for a specified delay and then navigates to the LoginPage
        public async Task NavigateAfterDelayAsync()
        {
            // Wait for X seconds; here, 3000 milliseconds equals 3 seconds
            await Task.Delay(3000);

            // Navigate to LoginPage using Shell navigation
            // Make sure the LoginPage route has been registered in AppShell.xaml.
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
