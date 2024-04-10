namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(Story), nameof(Story))]
[QueryProperty(nameof(Town), nameof(Town))]
public partial class ExploreStoryViewModel : ViewModelBase
{
    [ObservableProperty]
    private Story? _story;

    [ObservableProperty]
    private Town? _town;
}
