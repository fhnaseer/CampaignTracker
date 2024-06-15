namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(Town), nameof(Town))]
public partial class ExploreTownViewModel : ViewModelBase
{
    [ObservableProperty]
    private Town? _town;

    [RelayCommand]
    private async Task GoToStory(Story story)
    {
        await GoToStory(Town, story).ConfigureAwait(false);
    }

    protected override async Task GoBack()
    {
        if (CampaignData is null)
            return;

        Dictionary<string, object> state = new()
        {
            { nameof(CampaignData), CampaignData }
        };
        await Shell.Current.GoToAsync(nameof(CampaignViewModel), state).ConfigureAwait(false); ;
    }
}
