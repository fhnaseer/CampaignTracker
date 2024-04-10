namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(Story), nameof(Story))]
public partial class ExploreStoryViewModel : ViewModelBase
{
    [ObservableProperty]
    private Story? _story;
}
