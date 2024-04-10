using SleepingGodsDistantSkies.StaticContent;

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

    protected async Task GoToStory(Town? town, Story? story)
    {
        if (town is null || story is null)
            return;

        if (story.Status is Status.NotAvailable or Status.Crossed)
            return;

        Dictionary<string, object> state = new()
        {
            { nameof(Town), town },
            { nameof(Story), story },
            { nameof(CampaignData), CampaignData ?? new CampaignData("") }
        };

        if (story.Status == Status.Unexplored)
        {
            story.Status = Status.Explored;
            await Shell.Current.GoToAsync(nameof(AddStoryViewModel), state);
        }
        else
        {
            await Shell.Current.GoToAsync(nameof(ExploreStoryViewModel), state);
        }
    }

    [RelayCommand]
    protected async Task GoToTown(Town? town)
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

    [RelayCommand]
    protected void Save(CampaignData campaignData)
    {
        FileHelpers.SaveCampaign(campaignData);
    }
}
