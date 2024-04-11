namespace SleepingGodsDistantSkies.Model;

public partial class CampaignData : ObservableObject
{
    public CampaignData(string name)
    {
        Name = name;
        Towns = StaticContent.StoryData.GetTowns();
        Keywords = [];
    }

    [ObservableProperty]
    private string? _name;

    [ObservableProperty]
    private ObservableCollection<Town> _towns;

    [ObservableProperty]
    private ObservableCollection<string> _keywords;

}
