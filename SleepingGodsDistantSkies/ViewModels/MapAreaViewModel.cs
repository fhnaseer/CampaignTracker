using CommunityToolkit.Mvvm.ComponentModel;
using SleepingGodsDistantSkies.Model;

namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty("MapArea", "MapArea")]
public partial class MapAreaViewModel : ObservableObject
{
    [ObservableProperty]
    private MapArea? _mapArea;

    [ObservableProperty]
    private Model.Location? _selectedLocation;
}
