﻿namespace SleepingGodsDistantSkies.Model;

public partial class Story(string number) : ObservableObject
{
    [ObservableProperty]
    private string _number = number;

    [ObservableProperty]
    private ObservableCollection<Story> _stories = [];

    [ObservableProperty]
    private string? _requiredKeyword;

    [ObservableProperty]
    private Status _status;
}
