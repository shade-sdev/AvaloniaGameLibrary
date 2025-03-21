using System;
using System.Reactive;
using ReactiveUI;

namespace GameLibraryUI.ViewModels;

public class MainWindowViewModel : ViewModelBase, IScreen
{
    public string Title { get; } = "GameAvaLib";

    public RoutingState Router { get; } = new();

    public ReactiveCommand<Unit, IRoutableViewModel> NavigateHomeCommand    { get; }
    public ReactiveCommand<Unit, IRoutableViewModel> NavigateLibraryCommand { get; }

    private IRoutableViewModel? _selectedViewModel;

    public IRoutableViewModel? SelectedViewModel
    {
        get => _selectedViewModel;
        set => this.RaiseAndSetIfChanged(ref _selectedViewModel, value);
    }

    public MainWindowViewModel()
    {
        NavigateHomeCommand = ReactiveCommand.CreateFromObservable
            (() => Router.Navigate.Execute(new HomeViewModel(this)));

        NavigateLibraryCommand = ReactiveCommand.CreateFromObservable
            (() => Router.Navigate.Execute(new LibraryViewModel(this, Router)));

        Router.CurrentViewModel.Subscribe(viewModel => { SelectedViewModel = viewModel; });

        Router.Navigate.Execute(new HomeViewModel(this));
    }
}