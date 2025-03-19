using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using GameLibraryUI.Models;
using GameLibraryUI.Services;
using GameLibraryUI.Views.Partials;
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

    private void UpdateGamePages()
    {
        const int gamesPerPage = 4;

        if (_games.Count == 0)
        {
            GamePages.Clear();
            return;
        }

        GamePages.Clear();

        var pageCount = (int)Math.Ceiling((double)_games.Count / gamesPerPage);

        for (var i = 0; i < pageCount; i++)
        {
            var startIndex       = i * gamesPerPage;
            var endIndex         = Math.Min(startIndex + gamesPerPage, _games.Count);
            var currentPageGames = new ObservableCollection<Game>(_games.Skip(startIndex).Take(endIndex - startIndex));

            GamePages.Add(new GamePage { Games = currentPageGames });
        }

        this.RaisePropertyChanged(nameof(GamePages));
    }
}