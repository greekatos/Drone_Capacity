using Microsoft.Extensions.Logging;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Handlers;
using CommunityToolkit.Maui;
#if ANDROID
using Android.Content.Res; // Needed for ColorStateList
using SkiaSharp.Views.Maui.Controls.Hosting; // Needed for the MAP
using Android.Graphics;
#endif


namespace Drone_Capacity
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
#if ANDROID
                .UseSkiaSharp(true)  // Available only in ANDROID!
#endif
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            // Customize the Entry handler to remove the underline on Android
            builder.ConfigureMauiHandlers(handlers =>
            {
                EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
                {
#if ANDROID
                    // Remove underline by setting the BackgroundTintList to Transparent.
                    handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
#endif
                });
            });
            return builder.Build();
        }
    }
}
