using System;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;

namespace Drone_Capacity.Views
{
    public partial class AddCropPagePopup : Popup
    {
        public AddCropPagePopup()
        {
            InitializeComponent();
        }

        async void OnOkClicked(object sender, EventArgs e)
        {
            // 1) Hide all the input UI
            InputContainer.IsVisible = false;

            // 2) Show your confirmation image
            ConfirmIcon.IsVisible = true;

            // 3) Wait 3 seconds so the user sees it
            await Task.Delay(3000);

            // 4) Close the popup
            Close();
        }
    }
}
