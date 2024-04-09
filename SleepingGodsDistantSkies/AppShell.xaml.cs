using SleepingGodsDistantSkies.ViewModels;
using SleepingGodsDistantSkies.Views;

namespace SleepingGodsDistantSkies;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(MapAreaViewModel), typeof(MapAreaPage));
        Routing.RegisterRoute(nameof(LocationViewModel), typeof(LocationPage));
    }
}
