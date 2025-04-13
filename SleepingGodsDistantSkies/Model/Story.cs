namespace SleepingGodsDistantSkies.Model;

public partial class Story(string number) : ObservableObject
{
    [ObservableProperty]
    private string _number = number;

    [ObservableProperty]
    public ObservableCollection<string> _storyNumbers = [];

    [ObservableProperty]
    private ObservableCollection<Story> _stories = [];

    [ObservableProperty]
    private string? _requiredKeyword;

    [ObservableProperty]
    private string? _unavailableKeyword;

    [ObservableProperty]
    private Status _status;

    public override int GetHashCode()
    {
        return Number.GetHashCode();
    }

    public override string ToString()
    {
        return $"Story: {Number}\nStatus: {Status}" +
            $"{(string.IsNullOrWhiteSpace(RequiredKeyword) ? "" : $"\nRequired Keyword: {RequiredKeyword}")}" +
            $"{(string.IsNullOrWhiteSpace(UnavailableKeyword) ? "" : $"\nUnavailable Keyword: {UnavailableKeyword}")}";
    }
}
