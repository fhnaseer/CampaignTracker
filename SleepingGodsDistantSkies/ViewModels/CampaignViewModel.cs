namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(CampaignData), nameof(CampaignData))]
public partial class CampaignViewModel : ViewModelBase
{
    [ObservableProperty]
    private CampaignData? _campaignData;

    [RelayCommand]
    private async Task GoTo(MapArea mapArea)
    {
        await GoToMapArea(mapArea);
    }
}
