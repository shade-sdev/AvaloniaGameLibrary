using System.Reactive;
using GameLibraryUI.Models;
using GameLibraryUI.Services;
using ReactiveUI;

namespace GameLibraryUI.ViewModels;

public class GameViewModel : ViewPartialBase
{
    public RoutingState                              Router       { get; }
    public Game                                      SelectedGame { get; }
    public ReactiveCommand<Unit, IRoutableViewModel> BackCommand  { get; }

    public GameViewModel(IScreen screen, RoutingState router, Game game) : base(screen)
    {
        Router       = router;
        SelectedGame = game;

        BackCommand = ReactiveCommand.CreateFromObservable
            (() => Router.NavigateBack.Execute());
    }

    public GameViewModel() : base(null)
    {
        SelectedGame = GameService.Games[0];
    }
}