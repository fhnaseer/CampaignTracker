using System.ComponentModel;

namespace SleepingGodsDistantSkies.ViewModels;

[QueryProperty(nameof(Town), nameof(Town))]
[QueryProperty(nameof(Story), nameof(Story))]
public partial class ExploreStoryViewModel : ViewModelBase
{
    [ObservableProperty]
    private Town? _town;

    [ObservableProperty]
    private Story? _story;

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);

        if (e.PropertyName == nameof(Story) && Story is not null)
            Status = Story.Status;
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

    protected override async Task GoBack()
    {
        if (Story is not null)
            Story.Status = Status;

        if (Town is not null)
            await GoBackToTown(Town).ConfigureAwait(false);
    }

    [RelayCommand]
    private async Task GoBackToTown(Town town)
    {
        if (Story is not null)
            Story.Status = Status;

        Dictionary<string, object?> state = new()
        {
            { nameof(Town), town },
            { nameof(CampaignData), CampaignData }
        };
        await Shell.Current.GoToAsync(nameof(ExploreTownViewModel), state);
    }
}
