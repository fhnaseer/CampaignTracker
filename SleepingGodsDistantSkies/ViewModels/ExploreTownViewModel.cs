namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(Town), nameof(Town))]
public partial class ExploreTownViewModel : ViewModelBase
{
    [ObservableProperty]
    private Town? _town;

    [RelayCommand]
    private async Task GoToStory(Story story)
    {
        await GoToStory(Town, story, null, false);
    }
}
