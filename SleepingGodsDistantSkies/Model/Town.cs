﻿namespace SleepingGodsDistantSkies.Model;

public partial class Town(string name) : ObservableObject
{
    [ObservableProperty]
    private string _name = name;

    [ObservableProperty]
    private ObservableCollection<Story> _stories = [];
}
