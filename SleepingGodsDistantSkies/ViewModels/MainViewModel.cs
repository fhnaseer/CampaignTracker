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
        FileHelpers.CreateCampaign(NewCampaignName);
        _ = await FileHelpers.GetCampaigns();
        CampaignData data = new("start");
        Dictionary<string, object> dictionary = new()
        {
            { nameof(CampaignData), data}
        };
        await Shell.Current.GoToAsync(nameof(CampaignViewModel), dictionary);
    }

    [RelayCommand]
    private async Task LoadCampaign()
    {
        CampaignData data = new("start");
        Dictionary<string, object> dictionary = new()
        {
            { nameof(CampaignData), data}
        };
        await Shell.Current.GoToAsync(nameof(CampaignViewModel), dictionary);
    }


}
