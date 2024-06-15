namespace SleepingGodsDistantSkies.ViewModels;

public partial class CampaignViewModel : ViewModelBase
{
    [RelayCommand]
    private async Task GoToTown(Town? town)
    {
        if (town is null)
            return;

        Dictionary<string, object> state = new()
        {
            { nameof(Town), town },
            { nameof(CampaignData), CampaignData ?? new CampaignData("") }
        };
        await Shell.Current.GoToAsync(nameof(ExploreTownViewModel), state);
    }
}
