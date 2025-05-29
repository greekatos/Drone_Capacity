namespace Drone_Capacity.Views;
using Drone_Capacity.Models.ViewModels;
using Microsoft.Maui.Controls;


public partial class ChatBotPage : ContentPage
{
	public ChatBotPage()
	{
		InitializeComponent();
		BindingContext = new ChatBotPageViewModel();
	}
}