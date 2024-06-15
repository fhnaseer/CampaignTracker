namespace SleepingGodsDistantSkies.Model;

public partial class CampaignData : ObservableObject
{
    public CampaignData(string name, bool isDistantSkies)
    {
        Name = name;
        Towns = isDistantSkies ? StaticContent.StoryData.GetTowns() : [];
        Keywords = [];
        Stories = [];

        foreach (Town town in Towns)
        {
            foreach (Story story in town.Stories)
                Stories.Add(story.Number, story);
        }
    }

    [ObservableProperty]
    private string? _name;

    [ObservableProperty]
    private ObservableCollection<Town> _towns;

    [ObservableProperty]
    private ObservableCollection<string> _keywords;

    public Dictionary<string, Story> Stories { get; set; }
}
