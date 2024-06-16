namespace SleepingGodsDistantSkies.Model;

public partial class CampaignData : ObservableObject
{
    public CampaignData(string name)
    {
        Name = name;
    }

    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private ObservableCollection<Town> _towns = [];

    [ObservableProperty]
    private ObservableCollection<string> _keywords = [];

    [ObservableProperty]
    private Dictionary<string, Story> _stories = [];

    public override string ToString()
    {
        return Name;
    }
}
