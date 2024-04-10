namespace SleepingGodsDistantSkies.Views;

public partial class ExploreTownPage : ContentPage
{
    public ExploreTownPage(ExploreTownViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}