namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(Town), nameof(Town))]
[QueryProperty(nameof(Story), nameof(Story))]
public partial class AddStoryViewModel : ViewModelBase
{
    [ObservableProperty]
    private Town? _town;

    [ObservableProperty]
    private Story? _story;

    [ObservableProperty]
    private string? _storyNumber;

    [ObservableProperty]
    private string? _requiredKeyword;

    [ObservableProperty]
    private string? _unavailableKeyword;

    [RelayCommand]
    private void Add()
    {
        if (CampaignData is null || Story is null || StoryNumber is null)
            return;

        List<Story> stories = CampaignData.GetAllStories();
        Story? story = stories.FirstOrDefault(s => s.Number == StoryNumber);

        if (story != null)
            return;

        story ??= new(StoryNumber)
        {
            RequiredKeyword = RequiredKeyword?.ToUpper(),
            UnavailableKeyword = UnavailableKeyword?.ToUpper(),
        };

        Story.Stories.Add(story);
        StoryNumber = RequiredKeyword = UnavailableKeyword = null;
    }

    [RelayCommand]
    private async Task Explore()
    {
        if (Story is not null)
        {
            Story.Status = Status.NotVisited;
            await GoToStory(Town, Story).ConfigureAwait(false); ;
        }
    }
}
