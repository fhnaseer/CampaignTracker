namespace SleepingGodsDistantSkies.ViewModels;

public abstract partial class ViewModelBase : ObservableObject
{
    [RelayCommand]
    protected virtual async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }

    protected async Task GoToMapLocation(MapLocation mapLocation)
    {
        if (mapLocation.LocationStatus == LocationStatus.NotAvailable)
        {
            return;
        }

        Dictionary<string, object> dictionary = new()
        {
            { nameof(MapLocation), mapLocation }
        };
        await Shell.Current.GoToAsync(nameof(MapLocationViewModel), dictionary);
    }

    protected async Task GoToMapArea(MapArea mapArea)
    {
        Dictionary<string, object> dictionary = new()
        {
            { nameof(MapArea), mapArea }
        };
        await Shell.Current.GoToAsync(nameof(MapAreaViewModel), dictionary);
    }
}
