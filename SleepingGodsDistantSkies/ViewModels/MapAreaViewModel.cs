namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(MapArea), nameof(MapArea))]
public partial class MapAreaViewModel : ViewModelBase
{
    [ObservableProperty]
    private MapArea? _mapArea;

    [RelayCommand]
    private async Task SelectLocation(MapLocation mapLocation)
    {
        await GoToMapLocation(mapLocation).ConfigureAwait(false);
    }
}
