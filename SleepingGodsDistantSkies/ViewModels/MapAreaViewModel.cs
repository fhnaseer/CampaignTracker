using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SleepingGodsDistantSkies.Model;

namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(MapArea), nameof(MapArea))]
public partial class MapAreaViewModel : ViewModelBase
{
    [ObservableProperty]
    private MapArea? _mapArea;

    [ObservableProperty]
    private Model.Location? _selectedLocation;

    [RelayCommand]
    private async Task SelectLocation(Model.Location location)
    {
        Dictionary<string, object> dictionary = new()
        {
            { nameof(Model.Location), location }
        };
        await Shell.Current.GoToAsync(nameof(LocationViewModel), dictionary);
    }
}
