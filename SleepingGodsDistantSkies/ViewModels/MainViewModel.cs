using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SleepingGodsDistantSkies.Model;
using System.Collections.ObjectModel;

namespace SleepingGodsDistantSkies.ViewModels;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        MapAreas = StaticContent.MapAreas.GetMapAreas();
    }

    [ObservableProperty]
    private ObservableCollection<MapArea> _mapAreas;

    [RelayCommand]
    private async Task GoToMap(MapArea mapArea)
    {
        Dictionary<string, object> dictionary = new()
        {
            { nameof(MapArea), mapArea }
        };
        await Shell.Current.GoToAsync(nameof(MapAreaViewModel), dictionary);
    }
}
