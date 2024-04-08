using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SleepingGodsDistantSkies.Model;
using SleepingGodsDistantSkies.Views;

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
    private async void GoToMap(MapArea mapArea)
    {
    }
}
