namespace SleepingGodsDistantSkies.ViewModels;

public partial class AddStoryViewModel : StoryViewModelBase
{
    [ObservableProperty]
    private string? _storyNumber;

    [ObservableProperty]
    private string? _requiredKeyword;

    [RelayCommand]
    private void Add()
    {
        if (Story is null || StoryNumber is null)
            return;

        Story newStory = new(StoryNumber)
        {
            RequiredKeyword = RequiredKeyword
        };
        Story.Stories.Add(newStory);
    }

    [RelayCommand]
    private async Task Explore()
    {
        if (Story is not null)
            await GoToStory(Town, Story);
    }
}
