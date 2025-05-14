using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using System.Windows.Input;

namespace Drone_Capacity.Models.ViewModels
{
    public class LoginPageViewModel
    {
        // Command for Log In button navigation
        public ICommand LoginToHomeCommand { get; }
        // Command to navigate to RegisterPage when "Sign up is tapped"
        public ICommand SignUpCommand { get; }

        public LoginPageViewModel() 
        {
            // Initialize the command to navigate to HomePage
            LoginToHomeCommand = new Command(async () => await OnLogin());

            // SignUpCommand to navigate to RegisterPage
            SignUpCommand = new Command(async () => await NavigateToRegisterPage());
        }

        private async Task OnLogin()
        {
            // Use absolute routing to navigate to HomePage
            await Shell.Current.GoToAsync("//Home");
        }

        private async Task NavigateToRegisterPage()
        {
            // Ensure you have a route registered in AppShell for Register Page
            await Shell.Current.GoToAsync("//RegisterPage");
        }
    }
}