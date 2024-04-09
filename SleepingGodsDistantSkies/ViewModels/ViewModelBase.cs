using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SleepingGodsDistantSkies.ViewModels;

public abstract partial class ViewModelBase : ObservableObject
{
    [RelayCommand]
    private async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}
