using SleepingGodsDistantSkies.ViewModels;

namespace SleepingGodsDistantSkies.Views;

public partial class MapAreaPage : ContentPage
{
    public MapAreaPage(MapAreaViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}