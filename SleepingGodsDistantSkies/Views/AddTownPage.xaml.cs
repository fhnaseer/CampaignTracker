namespace SleepingGodsDistantSkies.Views;

public partial class AddTownPage : ContentPage
{
    public AddTownPage(AddTownViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}