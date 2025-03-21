using System.Collections.ObjectModel;
using System.Reactive;
using GameLibraryUI.Models;
using ReactiveUI;

namespace GameLibraryUI.ViewModels;

public class LibraryViewTypeModel : ViewPartialBase
{
    public RoutingState Router { get; }

    public ReactiveCommand<Unit, IRoutableViewModel> NavigateToGameView { get; }

    public LibraryViewType            ViewType { get; set; }
    public ObservableCollection<Game> Games    { get; set; }

    public LibraryViewTypeModel(IScreen                    screen,
                                RoutingState               router,
                                ObservableCollection<Game> games,
                                LibraryViewType            viewType) :
        base(screen)
    {
        Router   = router;
        ViewType = viewType;
        Games    = games;

        NavigateToGameView = ReactiveCommand.CreateFromObservable
            (() => Router.Navigate.Execute(new GameViewModel(screen)));
    }

    public LibraryViewTypeModel() : this(null, null, null, LibraryViewType.Grid)
    {
    }
}