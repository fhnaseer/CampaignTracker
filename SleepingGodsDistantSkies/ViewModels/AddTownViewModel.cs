namespace SleepingGodsDistantSkies.ViewModels;

public partial class AddTownViewModel : ViewModelBase
{
    [ObservableProperty]
    private string? _name;

    [ObservableProperty]
    private string? _stories;

    [RelayCommand]
    public void Add()
    {
        if (string.IsNullOrEmpty(Name) || string.IsNullOrWhiteSpace(Stories))
            return;

        Town town = new(Name);
        string[] stories = Stories.Split(',', StringSplitOptions.RemoveEmptyEntries);
        foreach (string story in stories)
            town.Stories.Add(new Story(story));
        CampaignData?.Towns.Add(town);

        Name = Stories = null;
    }

    protected override async Task GoBack()
    {
        await Shell.Current.GoToAsync("..").ConfigureAwait(false); ;
    }
}
