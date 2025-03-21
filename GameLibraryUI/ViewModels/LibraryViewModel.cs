using System.Collections.ObjectModel;
using System.Reactive;
using GameLibraryUI.Models;
using GameLibraryUI.Services;
using ReactiveUI;

namespace GameLibraryUI.ViewModels;

public class LibraryViewModel : ViewPartialBase, IScreen
{
    private static ObservableCollection<Game> Games => GameService.Games;

    public RoutingState ParentRouter { get; }
    public RoutingState Router       { get; } = new();

    public ReactiveCommand<Unit, IRoutableViewModel> NavigateGridView { get; }
    public ReactiveCommand<Unit, IRoutableViewModel> NavigateListView { get; }

    public LibraryViewModel(IScreen screen, RoutingState parentRouter) : base(screen)
    {
        ParentRouter = parentRouter;
        NavigateGridView = ReactiveCommand.CreateFromObservable
            (() => Router.Navigate.Execute(new LibraryViewTypeModel(this, ParentRouter, Games, LibraryViewType.Grid)));

        NavigateListView = ReactiveCommand.CreateFromObservable
            (() => Router.Navigate.Execute(new LibraryViewTypeModel(this, ParentRouter, Games, LibraryViewType.List)));

        Router.Navigate.Execute(new LibraryViewTypeModel(this, ParentRouter, Games, LibraryViewType.Grid));
    }

    public LibraryViewModel() : base(null!)
    {
        Router.Navigate.Execute(new LibraryViewTypeModel(this, ParentRouter, Games, LibraryViewType.List));
    }
}