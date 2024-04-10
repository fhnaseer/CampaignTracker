namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(CampaignData), nameof(CampaignData))]
public abstract partial class ViewModelBase : ObservableObject
{
    [ObservableProperty]
    private CampaignData? _campaignData;

    [RelayCommand]
    protected virtual async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }

    protected async Task GoToMapLocation(MapLocation mapLocation)
    {
        if (mapLocation.LocationStatus is LocationStatus.NotAvailable or LocationStatus.Crossed)
        {
            return;
        }

        if (mapLocation.LocationStatus == LocationStatus.Unexplored)
        {
            mapLocation.LocationStatus = LocationStatus.Explored;
        }

        Dictionary<string, object> state = new()
        {
            { nameof(MapLocation), mapLocation },
            { nameof(CampaignData), CampaignData ?? new CampaignData("") }
        };
        await Shell.Current.GoToAsync(nameof(MapLocationViewModel), state);
    }

    protected async Task GoToMapArea(MapArea mapArea)
    {
        Dictionary<string, object> state = new()
        {
            { nameof(MapArea), mapArea },
            { nameof(CampaignData), CampaignData ?? new CampaignData("") }
        };
        await Shell.Current.GoToAsync(nameof(MapAreaViewModel), state);
    }
}
