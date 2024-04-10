namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(Town), nameof(Town))]
public partial class ExploreTownViewModel : ViewModelBase
{
    [ObservableProperty]
    private Town? _town;
}
