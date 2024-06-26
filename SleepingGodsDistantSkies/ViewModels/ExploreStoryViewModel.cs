﻿using SleepingGodsDistantSkies.StaticContent;
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

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
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
    private async Task GoBackToTown(Town town)
    {
        if (CampaignData is null)
            return;

        if (Story is not null)
            Story.Status = Status;

        FileHelpers.PopulateTownStories(CampaignData, town);
        FileHelpers.SaveCampaign(CampaignData);

        Dictionary<string, object?> state = new()
        {
            { nameof(CampaignData), CampaignData }
        };
        await Shell.Current.GoToAsync(nameof(CampaignViewModel), state);
    }
}
