namespace SleepingGodsDistantSkies.ViewModels;

public partial class CampaignViewModel : ViewModelBase
{
    [RelayCommand]
    private async Task GoTo(MapArea mapArea)
    {
        await GoToMapArea(mapArea);
    }
}
