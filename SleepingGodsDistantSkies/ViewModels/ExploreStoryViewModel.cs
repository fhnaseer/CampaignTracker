using SleepingGodsDistantSkies.StaticContent;
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

    [ObservableProperty]
    private ObservableCollection<Status> _statuses = new(Enum.GetValues(typeof(Status)).Cast<Status>());

    [ObservableProperty]
    private Status _status;

    [ObservableProperty]
    private Town? _selectedTown;

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        SelectedTown ??= Town;

        base.OnPropertyChanged(e);

        if (e.PropertyName == nameof(Story) && Story is not null)
            Status = Story.Status;
    }

    [RelayCommand]
    private async Task GoToStory(Story story)
    {
        if (Story is not null)
            Story.Status = Status;

        FileHelpers.SaveCampaign(CampaignData);
        await GoToStory(Town, story).ConfigureAwait(false);
    }

    [RelayCommand]
    private async Task GoBackToTown()
    {
        if (CampaignData is null)
            return;

        if (Story is not null)
            Story.Status = Status;

        FileHelpers.SaveCampaign(CampaignData);
        if (Town is not null)
            FileHelpers.PopulateTownStories(CampaignData, Town);

        Dictionary<string, object?> state = new()
        {
            { nameof(Town), SelectedTown},
            { nameof(CampaignData), CampaignData }
        };
        string pageName = SelectedTown is null ? nameof(CampaignViewModel) : nameof(ExploreTownViewModel);
        await Shell.Current.GoToAsync(pageName, state);
    }
}
