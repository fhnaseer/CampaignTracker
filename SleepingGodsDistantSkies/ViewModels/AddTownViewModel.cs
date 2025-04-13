using SleepingGodsDistantSkies.StaticContent;

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
        if (string.IsNullOrEmpty(Name) || string.IsNullOrWhiteSpace(Stories) || CampaignData is null)
            return;

        Town town = new(Name);
        string[] storyNumbers = Stories.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string storyNumber in storyNumbers)
        {
            Story story = new(storyNumber);
            town.Stories.Add(story);
            CampaignData.Stories.Add(storyNumber, story);
        }

        CampaignData?.Towns.Add(town);
        Name = Stories = null;
        FileHelpers.SaveCampaign(CampaignData);
    }
}
