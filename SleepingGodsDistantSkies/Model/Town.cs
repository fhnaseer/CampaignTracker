namespace SleepingGodsDistantSkies.Model;

public partial class Town(string name) : ObservableObject
{
    [ObservableProperty]
    private string _name = name;

    [ObservableProperty]
    private ObservableCollection<Story> _stories = [];

    public override string ToString()
    {
        return Name;
    }

    public void PopulateStories(List<Story> stories)
    {
        foreach (Story story in Stories)
            story.PopulateStories(stories);
    }
}
