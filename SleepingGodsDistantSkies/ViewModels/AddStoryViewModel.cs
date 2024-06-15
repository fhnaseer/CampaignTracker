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

    [ObservableProperty]
    private ObservableCollection<Story> _existingStories = [];

    [RelayCommand]
    private void Add()
    {
        if (CampaignData is null || Story is null || StoryNumber is null)
            return;

        if (!CampaignData.Stories.TryGetValue(StoryNumber, out Story? story))
        {
            story = new(StoryNumber)
            {
                RequiredKeyword = RequiredKeyword?.ToUpper(),
                UnavailableKeyword = UnavailableKeyword?.ToUpper(),
            };
        }

        Story.Stories.Add(story);
        StoryNumber = RequiredKeyword = null;
    }

    [RelayCommand]
    private async Task Explore()
    {
        if (Story is not null)
        {
            Story.Status = Status.Explored;
            await GoToStory(Town, Story);
        }
    }
}
