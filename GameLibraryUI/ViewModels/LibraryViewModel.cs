using System.Collections.ObjectModel;
using System.Reactive;
using GameLibraryUI.Models;
using GameLibraryUI.Services;
using GameLibraryUI.Views.Partials;
using ReactiveUI;

namespace GameLibraryUI.ViewModels;

public class LibraryViewModel : ViewPartialBase
{
    public ReactiveCommand<Unit, Unit> SetGridViewCommand { get; }
    public ReactiveCommand<Unit, Unit> SetListViewCommand { get; }

    public LibraryViewModel(IScreen screen) : base(screen)
    {
    }

    public LibraryViewModel() : base(null!)
    {
    }

    public ObservableCollection<Game> Games { get; set; } = GameService.Games;
}