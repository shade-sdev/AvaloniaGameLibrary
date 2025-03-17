using System.Collections.ObjectModel;
using System.Reactive;
using GameLibraryUI.Models;
using GameLibraryUI.Services;
using GameLibraryUI.Views.Partials;
using ReactiveUI;

namespace GameLibraryUI.ViewModels;

public class LibraryViewModel : ViewPartialBase, IScreen
{
    private ObservableCollection<Game> Games { get; set; } = GameService.Games;

    public RoutingState Router { get; } = new();

    public ReactiveCommand<Unit, IRoutableViewModel> NavigateGridView { get; }
    public ReactiveCommand<Unit, IRoutableViewModel> NavigateListView { get; }

    public LibraryViewModel(IScreen screen) : base(screen)
    {
        NavigateGridView = ReactiveCommand.CreateFromObservable
            (() => Router.Navigate.Execute(new LibraryViewTypeModel(this, Games, LibraryViewType.Grid)));

        NavigateListView = ReactiveCommand.CreateFromObservable
            (() => Router.Navigate.Execute(new LibraryViewTypeModel(this, Games, LibraryViewType.List)));

        Router.Navigate.Execute(new LibraryViewTypeModel(this, Games, LibraryViewType.Grid));
    }

    public LibraryViewModel() : base(null!)
    {
        Router.Navigate.Execute(new LibraryViewTypeModel(this, Games, LibraryViewType.List));
    }
}