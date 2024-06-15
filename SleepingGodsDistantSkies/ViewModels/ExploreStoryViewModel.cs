using System.ComponentModel;

namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(Town), nameof(Town))]
[QueryProperty("CurrentStory", nameof(CurrentStory))]
public partial class ExploreStoryViewModel : ViewModelBase
{
    [ObservableProperty]
    private Town? _town;

    [ObservableProperty]
    private Story? _currentStory;

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);

        if (e.PropertyName == nameof(CurrentStory) && CurrentStory is not null)
            Status = CurrentStory.Status;
    }

    [ObservableProperty]
    private ObservableCollection<Status> _statuses = new(Enum.GetValues(typeof(Status)).Cast<Status>());

    [ObservableProperty]
    private Status _status;

    [RelayCommand]
    private async Task GoToStory(Story story)
    {
        await GoToStory(Town, story).ConfigureAwait(false);
    }

    protected override Task GoBack()
    {
        if (CurrentStory is not null)
            CurrentStory.Status = Status;

        return base.GoBack();
    }

    [RelayCommand]
    private async Task GoBackToTown(Town town)
    {
        Dictionary<string, object?> state = new()
        {
            { nameof(Town), town },
            { nameof(CampaignData), CampaignData }
        };
        await Shell.Current.GoToAsync(nameof(ExploreTownViewModel), state);
    }
}
