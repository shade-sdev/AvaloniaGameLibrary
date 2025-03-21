using System.Collections.ObjectModel;
using HexLaunch.Models;
using ReactiveUI;

namespace HexLaunch.ViewModels;

public class LibraryViewTypeModel : ViewPartialBase
{
    public RoutingState GrandParentRouter { get; }
    public RoutingState ParentRouter      { get; }

    public ReactiveCommand<Game, IRoutableViewModel> NavigateToGameView { get; }

    public LibraryViewType            ViewType { get; set; }
    public ObservableCollection<Game> Games    { get; set; }

    public LibraryViewTypeModel(IScreen                    screen,
                                RoutingState               grandParentRouter,
                                RoutingState               parentRouter,
                                ObservableCollection<Game> games,
                                LibraryViewType            viewType) :
        base(screen)
    {
        GrandParentRouter = grandParentRouter;
        ParentRouter      = parentRouter;
        ViewType          = viewType;
        Games             = games;

        NavigateToGameView = ReactiveCommand.CreateFromObservable<Game,
            IRoutableViewModel>(game => GrandParentRouter
                                        .Navigate
                                        .Execute(new GameViewModel(screen,
                                                                   GrandParentRouter,
                                                                   game)));
    }

    public LibraryViewTypeModel() : this(null, null, null, null, LibraryViewType.Grid)
    {
    }
}