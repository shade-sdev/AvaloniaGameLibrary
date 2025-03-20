using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using DynamicData;
using GameLibraryUI.Models;
using GameLibraryUI.Services;
using ReactiveUI;

namespace GameLibraryUI.ViewModels;

public class HomeViewModel : ViewPartialBase
{
    private          int                            _currentPage;
    private          ObservableCollection<GamePage> _gamePages = [];
    private readonly ObservableCollection<Game>     _games     = GameService.Games;

    public int CurrentPage
    {
        get => _currentPage;
        private set => this.RaiseAndSetIfChanged(ref _currentPage, value);
    }

    public ObservableCollection<GamePage> GamePages
    {
        get => _gamePages;
        set => this.RaiseAndSetIfChanged(ref _gamePages, value);
    }

    public ReactiveCommand<Unit, Unit> NextPageCommand     { get; }
    public ReactiveCommand<Unit, Unit> PreviousPageCommand { get; }

    public HomeViewModel(IScreen screen) : base(screen)
    {
        NextPageCommand = ReactiveCommand.Create(() =>
                                                 {
                                                     if (CurrentPage < GamePages.Count - 1)
                                                     {
                                                         CurrentPage++;
                                                     }
                                                 });

        PreviousPageCommand = ReactiveCommand.Create(() =>
                                                     {
                                                         if (CurrentPage > 0)
                                                         {
                                                             CurrentPage--;
                                                         }
                                                     });

        UpdateGamePages();
    }

    public HomeViewModel() : base(null)
    {
        UpdateGamePages();
    }

    private void UpdateGamePages()
    {
        const int gamesPerPage = 4;

        if (_games.Count == 0)
        {
            GamePages.Clear();
            return;
        }

        GamePages.Clear();

        GamePages.AddRange(_games
                           .Select((game, index) => new { game, index })
                           .GroupBy(x => x.index / gamesPerPage)
                           .Select(g => new GamePage
                                       { Games = new ObservableCollection<Game>(g.Select(x => x.game)) }));

        this.RaisePropertyChanged(nameof(GamePages));
    }
}