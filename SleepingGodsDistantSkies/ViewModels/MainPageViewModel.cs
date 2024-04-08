using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SleepingGodsDistantSkies.Model;

namespace SleepingGodsDistantSkies.ViewModels;

internal partial class MainPageViewModel : ObservableObject
{
    public MainPageViewModel()
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
