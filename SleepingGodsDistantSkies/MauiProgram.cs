using Microsoft.Extensions.Logging;

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
        builder.Services.AddSingleton<CampaignPage>();
        builder.Services.AddSingleton<CampaignViewModel>();
        builder.Services.AddSingleton<MapAreaPage>();
        builder.Services.AddSingleton<MapAreaViewModel>();
        builder.Services.AddSingleton<MapLocationPage>();
        builder.Services.AddSingleton<MapLocationViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
