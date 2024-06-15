using Microsoft.Extensions.Logging;

namespace SleepingGodsDistantSkies;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<CampaignPage>();
        builder.Services.AddSingleton<CampaignViewModel>();
        builder.Services.AddSingleton<AddTownPage>();
        builder.Services.AddSingleton<AddTownViewModel>();
        builder.Services.AddSingleton<ExploreTownPage>();
        builder.Services.AddSingleton<ExploreTownViewModel>();
        builder.Services.AddSingleton<AddStoryPage>();
        builder.Services.AddSingleton<AddStoryViewModel>();
        builder.Services.AddSingleton<ExploreStoryViewModel>();
        builder.Services.AddSingleton<ExploreStoryPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
