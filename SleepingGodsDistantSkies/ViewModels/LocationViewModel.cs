using CommunityToolkit.Mvvm.ComponentModel;

namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(Model.Location), nameof(Model.Location))]
public partial class LocationViewModel : ViewModelBase
{
    [ObservableProperty]
    private Model.Location? _location;
}
