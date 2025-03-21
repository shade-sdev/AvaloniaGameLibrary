using System.Collections.ObjectModel;
using System.Reactive;
using HexLaunch.Models;
using HexLaunch.Services;
using ReactiveUI;

namespace HexLaunch.ViewModels;

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
            (() => Router.Navigate.Execute(new LibraryViewTypeModel(this, ParentRouter, Router, Games,
                                                                    LibraryViewType.Grid)));

        NavigateListView = ReactiveCommand.CreateFromObservable
            (() => Router.Navigate.Execute(new LibraryViewTypeModel(this, ParentRouter, Router, Games,
                                                                    LibraryViewType.List)));

        Router.Navigate.Execute(new LibraryViewTypeModel(this, ParentRouter, Router, Games, LibraryViewType.Grid));
    }

    public LibraryViewModel() : base(null!)
    {
        Router.Navigate.Execute(new LibraryViewTypeModel(this, ParentRouter, Router, Games, LibraryViewType.List));
    }
}