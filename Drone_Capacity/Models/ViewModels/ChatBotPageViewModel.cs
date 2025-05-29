using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Drone_Capacity.Models.ViewModels
{
    class ChatBotPageViewModel
    {
        // Command for navigation back to the consultant page
        public  ICommand NavigateBackToConsultantPage { get; }
        // Command to go to the chatbot
        public ICommand NavigateToChatBot { get; }

        public ChatBotPageViewModel()
        {
            NavigateBackToConsultantPage = new Command(async () => await ConsultantPlayBack());
            NavigateToChatBot = new Command(async () => await ChatBotPageChat());
        }

        private async Task ConsultantPlayBack()
        {
            await Shell.Current.GoToAsync("//Consultant");
        }

        private async Task ChatBotPageChat()
        {
            await Shell.Current.GoToAsync("//ChatBotMessenger");
        }
    }
}
