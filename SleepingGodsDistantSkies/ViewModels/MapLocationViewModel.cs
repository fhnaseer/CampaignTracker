namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(MapLocation), nameof(MapLocation))]
public partial class MapLocationViewModel : ViewModelBase
{
    [ObservableProperty]
    private MapLocation? _mapLocation;

    protected override Task GoBack()
    {
        if (MapLocation is not null)
        {
            MapLocation.LocationStatus = LocationStatus.Explored;
        }

        return base.GoBack();
    }
}
