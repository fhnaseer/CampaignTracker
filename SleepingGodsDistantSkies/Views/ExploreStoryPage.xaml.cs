namespace SleepingGodsDistantSkies.Views;

public partial class ExploreStoryPage : ContentPage
{
    public ExploreStoryPage(ExploreStoryViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}