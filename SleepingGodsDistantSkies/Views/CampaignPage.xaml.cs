namespace SleepingGodsDistantSkies.Views;

public partial class CampaignPage : ContentPage
{
    public CampaignPage(CampaignViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}