using Microsoft.Extensions.Logging;
using SleepingGodsDistantSkies.ViewModels;
using SleepingGodsDistantSkies.Views;

namespace SleepingGodsDistantSkies;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();

        //builder.Services.AddSingleton<MapAreaPage>();
        //builder.Services.AddSingleton<MapAreaViewModel>();
        //builder.Services.AddSingleton<LocationPage>();
        //builder.Services.AddSingleton<LocationViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
