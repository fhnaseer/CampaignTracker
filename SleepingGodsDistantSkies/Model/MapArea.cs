using CommunityToolkit.Mvvm.ComponentModel;

namespace SleepingGodsDistantSkies.Model;

internal partial class MapArea : ObservableObject
{
    public MapArea(string mapName, string imageName, int startPage, int endPage)
    {
        _name = mapName;
        _image = new Image { Source = ImageSource.FromFile(imageName) };
        _startPage = startPage;
        _endPage = endPage;
    }

    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private Image _image;

    [ObservableProperty]
    private int _startPage;

    [ObservableProperty]
    private int _endPage;
}
