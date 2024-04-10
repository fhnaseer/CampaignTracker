using System.Text.Json.Serialization;

namespace SleepingGodsDistantSkies.Model;

public partial class CampaignData : ObservableObject
{
    public CampaignData(string name)
    {
        Name = name;
        MapAreas = StaticContent.MapAreas.GetMapAreas();
        Keywords = [];
    }

    [ObservableProperty]
    private string? _name;

    [property: JsonIgnore]
    [ObservableProperty]
    private ObservableCollection<MapArea> _mapAreas;

    [ObservableProperty]
    private ObservableCollection<string> _keywords;
}
