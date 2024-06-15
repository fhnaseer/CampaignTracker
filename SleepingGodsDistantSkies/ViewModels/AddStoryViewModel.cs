namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(Town), nameof(Town))]
[QueryProperty("CurrentStory", nameof(CurrentStory))]
public partial class AddStoryViewModel : ViewModelBase
{
    [ObservableProperty]
    private Town? _town;

    [ObservableProperty]
    private Story? _currentStory;

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
        if (CampaignData is null || CurrentStory is null || StoryNumber is null)
            return;

        if (!CampaignData.Stories.TryGetValue(StoryNumber, out Story? story))
        {
            story = new(StoryNumber)
            {
                RequiredKeyword = RequiredKeyword,
                UnavailableKeyword = UnavailableKeyword,
            };
        }

        CurrentStory.Stories.Add(story);
        StoryNumber = RequiredKeyword = null;
    }

    [RelayCommand]
    private async Task Explore()
    {
        if (CurrentStory is not null)
        {
            CurrentStory.Status = Status.Explored;
            await GoToStory(Town, CurrentStory);
        }
    }
}
