namespace SleepingGodsDistantSkies.Model;

public partial class CampaignData : ObservableObject
{
    public CampaignData(string name, bool isDistantSkies)
    {
        Name = name;
        Towns = isDistantSkies ? StaticContent.StoryData.GetDistantSkiesTowns() : [];
        Keywords = [];
        AdditionalStories = [];
    }

    [ObservableProperty]
    private string? _name;

    [ObservableProperty]
    private ObservableCollection<Town> _towns;

    [ObservableProperty]
    private ObservableCollection<string> _keywords;

    [ObservableProperty]
    private ObservableCollection<Story> _additionalStories = [];

    [ObservableProperty]
    private bool _isDistantSkies;

    public override string ToString()
    {
        return Name ?? string.Empty;
    }

    public List<Story> GetAllStories()
    {
        List<Story> stories = new(AdditionalStories);

        foreach (Town town in Towns)
            town.PopulateStories(stories);

        return stories;
    }
}
