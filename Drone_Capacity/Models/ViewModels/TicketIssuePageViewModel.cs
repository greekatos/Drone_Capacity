using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Drone_Capacity.Models.ViewModels
{
    public class TicketIssuePageViewModel
    {
        // Command for navigation to HomePage
        public ICommand NavigateBackToConsultantPage { get; }

        public TicketIssuePageViewModel() 
        {
            NavigateBackToConsultantPage = new Command(async () => await ConsultantPlayBack());
        }

        private async Task ConsultantPlayBack()
        {
            await Shell.Current.GoToAsync("//Consultant");
        }
    }
}
