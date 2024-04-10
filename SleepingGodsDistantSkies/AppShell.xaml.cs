namespace SleepingGodsDistantSkies;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(CampaignViewModel), typeof(CampaignPage));
        Routing.RegisterRoute(nameof(MapAreaViewModel), typeof(MapAreaPage));
        Routing.RegisterRoute(nameof(MapLocationViewModel), typeof(MapLocationPage));
    }
}
