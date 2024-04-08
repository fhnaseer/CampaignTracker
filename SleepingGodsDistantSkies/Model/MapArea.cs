using CommunityToolkit.Mvvm.ComponentModel;

namespace SleepingGodsDistantSkies.Model;

internal partial class MapArea(string mapName, string imageName, int startPage, int endPage: ObservableObject
{
    public MapArea? North { get; set; }

    public MapArea? East { get; set; }

    public MapArea? South { get; set; }

    public MapArea? West { get; set; }

    [ObservableProperty]
    private string _name = mapName;

    [ObservableProperty]
    private ImageSource _image = ImageSource.FromFile(imageName);

    [ObservableProperty]
    private int _startPage = startPage;

    [ObservableProperty]
    private int _endPage = endPage;

    [ObservableProperty]
    private List<Location> _locations = [];
}
