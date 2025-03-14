﻿using System;
using System.Reactive;
using ReactiveUI;

namespace GameLibraryUI.ViewModels;

public class MainWindowViewModel : ViewModelBase, IScreen
{
    public string Title { get; } = "GameAvaLib";


    public RoutingState Router { get; } = new();

    public ReactiveCommand<Unit, IRoutableViewModel> NavigateHomeCommand    { get; }
    public ReactiveCommand<Unit, IRoutableViewModel> NavigateLibraryCommand { get; }

    public MainWindowViewModel()
    {
        NavigateHomeCommand = ReactiveCommand.CreateFromObservable
            (() => Router.Navigate.Execute(new HomeViewModel(this)));

        NavigateLibraryCommand = ReactiveCommand.CreateFromObservable
            (() => Router.Navigate.Execute(new LibraryViewModel(this)));

        Router.Navigate.Execute(new LibraryViewModel(this));
        Console.WriteLine(Router?.GetCurrentViewModel()?.GetType().Name);
    }
}