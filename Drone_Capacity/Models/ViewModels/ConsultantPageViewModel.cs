using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;


namespace Drone_Capacity.Models.ViewModels
{
    public class ConsultantPageViewModel
    {
        // Command for navigation to HomePage
        public ICommand NavigateBackToHomePage { get; }
        // Command for navigation to the Ticket Issue
        public ICommand NavigatetoTicketIssue {  get; }
        // Command for navigation to the ChatBot
        public ICommand NavigatetoChatBot { get; }

        public ConsultantPageViewModel()
        {
            // Initialize the commands
            NavigateBackToHomePage = new Command(async () => await NavigateBackToHomePageMenu());
            NavigatetoTicketIssue = new Command(async () => await NavigateToTicketIssuePage());
            NavigatetoChatBot = new Command(async () => await NavigateToChatBotPage());
        }

        private async Task NavigateBackToHomePageMenu()
        {
            await Shell.Current.GoToAsync("//Home");
        }

        private async Task NavigateToTicketIssuePage()
        {
            await Shell.Current.GoToAsync("//TicketIssuePage");
        }

        private async Task NavigateToChatBotPage()
        {
            await Shell.Current.GoToAsync("//ChatBotPage");
        }
    }
}
