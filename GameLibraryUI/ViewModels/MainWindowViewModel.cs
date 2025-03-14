using System;
using System.Reactive;
using ReactiveUI;

namespace GameLibraryUI.ViewModels;

public class MainWindowViewModel : ViewModelBase, IScreen
{
    public static string Title => "GameAvaLib";

    public RoutingState Router { get; } = new();

    public ReactiveCommand<Unit, IRoutableViewModel> NavigateHomeCommand { get; }

    public MainWindowViewModel()
    {
        NavigateHomeCommand = ReactiveCommand.CreateFromObservable
            (() => Router.Navigate.Execute(new HomeViewModel(this)));

        Router.Navigate.Execute(new HomeViewModel(this));
        Console.WriteLine(Router?.GetCurrentViewModel()?.GetType().Name);
    }
}