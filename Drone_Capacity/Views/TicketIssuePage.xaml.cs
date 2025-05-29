namespace Drone_Capacity.Views;
using Drone_Capacity.Models.ViewModels;
using Microsoft.Maui.Controls;

public partial class TicketIssuePage : ContentPage
{
	public TicketIssuePage()
	{
		InitializeComponent();
		BindingContext = new TicketIssuePageViewModel(); 
	}

    async void OnSubmitClicked(object sender, EventArgs e)
    {
        // Generate a fake ticket ID (e.g. random 5-digit)
        var random = new Random();
        var ticketId = random.Next(10000, 99999);

        // 1) Show confirmation alert
        await DisplayAlert(
            "Ticket Submitted",
            $"Your ticket ID is {ticketId}. It has been forwarded to our support team.",
            "OK");

        // 2) Navigate back home
        await Shell.Current.GoToAsync("//Home");
    }
}