using Microsoft.Maui.Controls;
using Drone_Capacity.Models.ViewModels;

namespace Drone_Capacity
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            viewModel = new MainPageViewModel();
            BindingContext = viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing(); // After the page has been initialized
            // Trigger the delayed navigation defined in the ViewModel
            await viewModel.NavigateAfterDelayAsync();
        }
    }

}
