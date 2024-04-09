using CommunityToolkit.Mvvm.ComponentModel;
using SleepingGodsDistantSkies.Model;

namespace SleepingGodsDistantSkies.ViewModels;

public partial class MapAreaViewModel : ObservableObject
{
    public MapArea? MapArea { get; set; }

    [ObservableProperty]
    private Model.Location? _selectedLocation;
}
