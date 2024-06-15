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
        await Task.CompletedTask.ConfigureAwait(false);// Shell.Current.GoToAsync("..");
    }

    protected async Task GoToStory(Town? town, Story? story)
    {
        if (town is null || story is null)
            return;

        if (story.Status is Status.NotAvailable or Status.Crossed)
            return;

        Dictionary<string, object?> state = new()
        {
            { nameof(Town), town },
            { "CurrentStory", story },
            { nameof(CampaignData), CampaignData}
        };

        string viewModeName = story.Status == Status.Unexplored ? nameof(AddStoryViewModel) : nameof(ExploreStoryViewModel);
        story.Status = Status.Explored;
        await Shell.Current.GoToAsync(viewModeName, state).ConfigureAwait(false);
    }

    [RelayCommand]
    protected void Save(CampaignData campaignData)
    {
        FileHelpers.SaveCampaign(campaignData);
    }
}
