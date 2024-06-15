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
            { nameof(CampaignData), CampaignData ?? new CampaignData("", true) }
        };
        await Shell.Current.GoToAsync(nameof(ExploreTownViewModel), state).ConfigureAwait(false); ;
    }

    [RelayCommand]
    private async Task AddTown()
    {
        Dictionary<string, object> state = new()
        {
            { nameof(CampaignData), CampaignData ?? new CampaignData("", true) }
        };
        await Shell.Current.GoToAsync(nameof(AddTownViewModel), state).ConfigureAwait(false); ;
    }
}
