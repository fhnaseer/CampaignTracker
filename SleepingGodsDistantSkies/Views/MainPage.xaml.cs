﻿using SleepingGodsDistantSkies.ViewModels;

namespace SleepingGodsDistantSkies.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }
}
