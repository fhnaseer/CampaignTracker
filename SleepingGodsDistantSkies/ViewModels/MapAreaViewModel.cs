using CommunityToolkit.Mvvm.ComponentModel;
using SleepingGodsDistantSkies.Model;

namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(MapArea), nameof(MapArea))]
public partial class MapAreaViewModel : ViewModelBase
{
    [ObservableProperty]
    private MapArea? _mapArea;

    [ObservableProperty]
    private Model.Location? _selectedLocation;
}
