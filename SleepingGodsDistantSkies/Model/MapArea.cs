using System.Text.Json.Serialization;

namespace SleepingGodsDistantSkies.Model;

public partial class MapArea(string mapName, string imageName, int startPage, int endPage) : ObservableObject
{
    [JsonPropertyName("Name")]
    [ObservableProperty]
    private string _name = mapName;

    [JsonIgnore]
    [ObservableProperty]
    private ImageSource _image = ImageSource.FromFile(imageName);

    [JsonPropertyName("StartPage")]
    [ObservableProperty]
    private int _startPage = startPage;

    [JsonPropertyName("EndPage")]
    [ObservableProperty]
    private int _endPage = endPage;

    [JsonIgnore]
    [ObservableProperty]
    private List<MapLocation> _locations = [];
}
