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

    [ObservableProperty]
    private CampaignData? _selectedCampaign;

    [RelayCommand]
    private async Task StartDistantSkiesCampaign()
    {
        if (string.IsNullOrWhiteSpace(NewCampaignName))
            return;

        SelectedCampaign = FileHelpers.CreateCampaign(NewCampaignName, true);
        await LoadCampaign().ConfigureAwait(false); ;
    }

    [RelayCommand]
    private async Task StartEmptyCampaign()
    {
        if (string.IsNullOrWhiteSpace(NewCampaignName))
            return;

        SelectedCampaign = FileHelpers.CreateCampaign(NewCampaignName, false);
        await LoadCampaign().ConfigureAwait(false); ;
    }

    [RelayCommand]
    private async Task LoadCampaign()
    {
        if (SelectedCampaign == null)
            return;

        Dictionary<string, object> state = new()
        {
            { nameof(CampaignData), SelectedCampaign }
        };
        await Shell.Current.GoToAsync(nameof(CampaignViewModel), state).ConfigureAwait(false); ;
    }

    [RelayCommand]
    private async Task DeleteCampaign()
    {
        if (SelectedCampaign == null || SelectedCampaign.Name == null)
            return;

        FileHelpers.DeleteCampaign(SelectedCampaign.Name);
        Campaigns = await FileHelpers.GetCampaigns().ConfigureAwait(false);
    }
}
