namespace SleepingGodsDistantSkies.Model;

public partial class CampaignData : ObservableObject
{
    public CampaignData(string name, bool isDistantSkies)
    {
        Name = name;
        Towns = isDistantSkies ? StaticContent.StoryData.GetDistantSkiesTowns() : [];
        Keywords = [];
        Stories = [];

        foreach (Town town in Towns)
        {
            foreach (Story story in town.Stories)
                Stories.Add(story);
        }
    }

    [ObservableProperty]
    private string? _name;

    [ObservableProperty]
    private ObservableCollection<Town> _towns;

    [ObservableProperty]
    private ObservableCollection<string> _keywords;

    [ObservableProperty]
    private ObservableCollection<Story> _stories = [];

    [ObservableProperty]
    private bool _isDistantSkies;

    public override string ToString()
    {
        return Name ?? string.Empty;
    }
}
