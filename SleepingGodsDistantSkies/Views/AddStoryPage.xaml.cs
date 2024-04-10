namespace SleepingGodsDistantSkies.Views;

public partial class AddStoryPage : ContentPage
{
    public AddStoryPage(AddStoryViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}