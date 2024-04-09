using SleepingGodsDistantSkies.ViewModels;

namespace SleepingGodsDistantSkies.Views;

public partial class LocationPage : ContentPage
{
    public LocationPage(LocationViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}