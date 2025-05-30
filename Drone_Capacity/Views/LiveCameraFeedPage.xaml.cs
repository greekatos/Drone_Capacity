using CommunityToolkit.Maui.Views;

namespace Drone_Capacity.Views;

public partial class LiveCameraFeedPage : ContentPage
{
	public LiveCameraFeedPage()
	{
		InitializeComponent();
	}

    async void OnCameraDotTapped(object sender, TappedEventArgs e)
    {
        // 1) Show the processing popup
        var popup = new CameraProcessingPopup();
        Shell.Current.ShowPopup(popup);

        // 2) Fake “running AI” for 5 seconds
        await Task.Delay(5000);

        // 3) Close the popup
        popup.Close();

        // 4) Navigate to the fake report page
        await Shell.Current.GoToAsync("//ReportDiseaseGeneration");
    }
}