using SleepingGodsDistantSkies.StaticContent;

namespace SleepingGodsDistantSkies.ViewModels;

public partial class MainViewModel : ObservableObject
{

    public MainViewModel()
    {
        _campaigns = FileHelpers.GetCampaigns().Result;
    }

    [ObservableProperty]
    private string _newCampaignName = string.Empty;

    [ObservableProperty]
    private ObservableCollection<CampaignData> _campaigns;

    [RelayCommand]
    private async Task StartCampaign()
    {
        CampaignData campaignData = FileHelpers.CreateCampaign(NewCampaignName);
        await LoadCampaign(campaignData);
    }

    [RelayCommand]
    private async Task LoadCampaign(CampaignData campaignData)
    {
        Dictionary<string, object> dictionary = new()
        {
            { nameof(CampaignData), campaignData}
        };
        await Shell.Current.GoToAsync(nameof(CampaignViewModel), dictionary);
    }
}
