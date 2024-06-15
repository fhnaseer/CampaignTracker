using SleepingGodsDistantSkies.StaticContent;

namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(CampaignData), nameof(CampaignData))]
public abstract partial class ViewModelBase : ObservableObject
{
    [ObservableProperty]
    private CampaignData? _campaignData;

    [ObservableProperty]
    private string _keyword = string.Empty;

    [RelayCommand]
    protected virtual async Task GoBack()
    {
        await Task.CompletedTask.ConfigureAwait(false);// Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    protected void AddKeyword()
    {
        if (!string.IsNullOrWhiteSpace(Keyword))
            CampaignData?.Keywords.Add(Keyword);
    }

    [RelayCommand]
    protected void RemoveKeyword()
    {
        if (!string.IsNullOrWhiteSpace(Keyword))
            _ = (CampaignData?.Keywords.Remove(Keyword));
    }

    protected async Task GoToStory(Town? town, Story? story)
    {
        if (town is null || story is null || CampaignData is null)
            return;

        if (story.Status is Status.NotAvailable or Status.Crossed)
            return;

        if (!string.IsNullOrWhiteSpace(story.RequiredKeyword) && !CampaignData.Keywords.Contains(story.RequiredKeyword))
            return;

        if (!string.IsNullOrWhiteSpace(story.UnavailableKeyword) && CampaignData.Keywords.Contains(story.UnavailableKeyword))
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
