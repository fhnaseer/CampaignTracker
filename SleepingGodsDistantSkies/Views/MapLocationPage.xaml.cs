namespace SleepingGodsDistantSkies.Views;

public partial class MapLocationPage : ContentPage
{
    public MapLocationPage(MapLocationViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}