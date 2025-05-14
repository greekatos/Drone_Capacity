using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using System.Windows.Input;

namespace Drone_Capacity.Models.ViewModels
{
    // Command to navigate to LoginPage when Log In is tapped
    public class RegisterPageViewModel
    {
        // Command to navigate to RegisterPage when "Sign up is tapped"
        public ICommand LogInCommand { get; }

        public RegisterPageViewModel()
        {
            LogInCommand = new Command(async () => await NavigateToLoginPage());
        }

        private async Task NavigateToLoginPage()
        {
            // Ensure you have a route registered in AppShell for Register Page
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
