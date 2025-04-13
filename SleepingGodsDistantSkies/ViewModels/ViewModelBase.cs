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
        if (CampaignData is null)
            return;

        Dictionary<string, object> state = new()
        {
            { nameof(CampaignData), CampaignData }
        };
        await Shell.Current.GoToAsync(nameof(CampaignViewModel), state).ConfigureAwait(false);
    }

    [RelayCommand]
    protected void AddKeyword()
    {
        _ = (CampaignData?.Keywords.Remove(Keyword.ToUpper()));

        if (!string.IsNullOrWhiteSpace(Keyword))
            CampaignData?.Keywords.Add(Keyword.ToUpper());

        Keyword = string.Empty;
        FileHelpers.SaveCampaign(CampaignData);
    }

    [RelayCommand]
    protected void RemoveKeyword()
    {
        if (!string.IsNullOrWhiteSpace(Keyword))
            _ = (CampaignData?.Keywords.Remove(Keyword.ToUpper()));

        Keyword = string.Empty;
        FileHelpers.SaveCampaign(CampaignData);
    }

    [RelayCommand]
    protected void CrossStory()
    {
        if (!string.IsNullOrWhiteSpace(Keyword))
            _ = (CampaignData?.Stories.Remove(Keyword));

        Keyword = string.Empty;
        FileHelpers.SaveCampaign(CampaignData);
    }

    protected async Task GoToStory(Town? town, Story? story)
    {
        if (town is null || story is null || CampaignData is null)
            return;

        if (story.Status is Status.NotAvailable or Status.Crossed)
            return;

        if (!string.IsNullOrWhiteSpace(story.RequiredKeyword) && !CampaignData.Keywords.Contains(story.RequiredKeyword.ToUpper()))
            return;

        if (!string.IsNullOrWhiteSpace(story.UnavailableKeyword) && CampaignData.Keywords.Contains(story.UnavailableKeyword.ToUpper()))
            return;

        Dictionary<string, object?> state = new()
        {
            { nameof(Town), town },
            { nameof(Story), story },
            { nameof(CampaignData), CampaignData}
        };

        string viewModeName = story.Status == Status.Unexplored ? nameof(AddStoryViewModel) : nameof(ExploreStoryViewModel);
        if (story.Status == Status.Unexplored)
            story.Status = Status.NotVisited;

        FileHelpers.SaveCampaign(CampaignData);
        FileHelpers.PopulateStories(CampaignData, story);

        await Shell.Current.GoToAsync(viewModeName, state).ConfigureAwait(false);
    }
}
