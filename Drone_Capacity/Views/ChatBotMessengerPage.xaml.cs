namespace Drone_Capacity.Views;
using Drone_Capacity.Models.ViewModels;
using Microsoft.Maui.Controls;


public partial class ChatBotMessengerPage : ContentPage
{
	public ChatBotMessengerPage()
	{
		InitializeComponent();
		BindingContext = new ChatBotMessageViewModel();
	}
}