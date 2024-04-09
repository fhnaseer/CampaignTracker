using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SleepingGodsDistantSkies.Model;

namespace SleepingGodsDistantSkies.ViewModels;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        _mapAreas = StaticContent.MapAreas.GetMapAreas();
    }

    [ObservableProperty]
    private MapArea[] _mapAreas;

    [RelayCommand]
    private void GoToMap(MapArea mapArea)
    {
    }
}
