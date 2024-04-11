using System.ComponentModel;

namespace SleepingGodsDistantSkies.ViewModels;

public partial class AddStoryViewModel : StoryViewModelBase
{
    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);

        if (e.PropertyName == nameof(ParentStory) && ParentStory is not null)
        {
            ExistingStories.Clear();
            ExistingStories.Add(ParentStory);

            foreach (Story child in ParentStory.Stories)
                ExistingStories.Add(child);
        }
    }

    [ObservableProperty]
    private string? _storyNumber;

    [ObservableProperty]
    private string? _requiredKeyword;

    [ObservableProperty]
    private Story? _selectedExistingStory;

    [ObservableProperty]
    private ObservableCollection<Story> _existingStories = [];

    [RelayCommand]
    private void Add()
    {
        if (CurrentStory is null || StoryNumber is null)
            return;

        Story newStory = new(StoryNumber)
        {
            RequiredKeyword = RequiredKeyword
        };
        CurrentStory.Stories.Add(newStory);
        StoryNumber = RequiredKeyword = null;
    }

    [RelayCommand]
    private void AddExistingStory(Story existingStory)
    {
        if (SelectedExistingStory is null || CurrentStory is null)
            return;

        CurrentStory.Stories.Add(existingStory);
        StoryNumber = RequiredKeyword = null;
    }

    [RelayCommand]
    private async Task Explore()
    {
        if (CurrentStory is not null)
            await GoToStory(Town, CurrentStory, ParentStory, true);
    }
}
