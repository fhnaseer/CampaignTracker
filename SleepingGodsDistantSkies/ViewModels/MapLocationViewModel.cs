namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(MapLocation), nameof(MapLocation))]
public partial class MapLocationViewModel : ViewModelBase
{
    [ObservableProperty]
    private MapLocation? _mapLocation;
}
