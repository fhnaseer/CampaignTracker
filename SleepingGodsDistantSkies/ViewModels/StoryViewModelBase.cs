namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty("CurrentStory", nameof(CurrentStory))]
[QueryProperty("ParentStory", nameof(ParentStory))]
[QueryProperty(nameof(Town), nameof(Town))]
public abstract partial class StoryViewModelBase : ViewModelBase
{
    [ObservableProperty]
    private Story? _currentStory;

    [ObservableProperty]
    private Story? _parentStory;

    [ObservableProperty]
    private Town? _town;

    [RelayCommand]
    private async Task GoToStory(Story story)
    {
        await GoToStory(Town, story, CurrentStory, false);
    }
}
