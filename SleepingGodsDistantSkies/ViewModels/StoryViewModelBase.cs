namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(Story), nameof(Story))]
[QueryProperty(nameof(Town), nameof(Town))]
public abstract partial class StoryViewModelBase : ViewModelBase
{
    [ObservableProperty]
    private Story? _story;

    [ObservableProperty]
    private Town? _town;

    [RelayCommand]
    private async Task GoToStory(Story story)
    {
        await GoToStory(Town, story);
    }
}
