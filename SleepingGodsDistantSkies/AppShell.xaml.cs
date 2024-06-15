namespace SleepingGodsDistantSkies;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(MainViewModel), typeof(MainPage));
        Routing.RegisterRoute(nameof(CampaignViewModel), typeof(CampaignPage));
        Routing.RegisterRoute(nameof(AddTownViewModel), typeof(AddTownPage));
        Routing.RegisterRoute(nameof(ExploreTownViewModel), typeof(ExploreTownPage));
        Routing.RegisterRoute(nameof(ExploreStoryViewModel), typeof(ExploreStoryPage));
        Routing.RegisterRoute(nameof(AddStoryViewModel), typeof(AddStoryPage));
    }
}
