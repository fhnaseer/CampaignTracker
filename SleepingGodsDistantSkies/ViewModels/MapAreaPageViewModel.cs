using CommunityToolkit.Mvvm.ComponentModel;
using SleepingGodsDistantSkies.Model;
namespace SleepingGodsDistantSkies.ViewModels;

internal partial class MapAreaPageViewModel : ObservableObject
{
    public MapArea? MapArea { get; set; }

    [ObservableProperty]
    private Model.Location? _selectedLocation;
}
