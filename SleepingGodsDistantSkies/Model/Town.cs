namespace SleepingGodsDistantSkies.Model;

public partial class Town(string name) : ObservableObject
{
    [ObservableProperty]
    private string _name = name;

    [ObservableProperty]
    public List<string> _storyNumbers = [];

    [ObservableProperty]
    private ObservableCollection<Story> _stories = [];

    public override string ToString()
    {
        return Name;
    }
}
