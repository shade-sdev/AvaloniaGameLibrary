using System.Collections.ObjectModel;
using GameLibraryUI.Models;
using ReactiveUI;

namespace GameLibraryUI.ViewModels;

public class LibraryViewTypeModel(IScreen screen, ObservableCollection<Game> games, LibraryViewType viewType)
    : ViewPartialBase(screen)
{
    public LibraryViewType ViewType { get; set; } = viewType;

    public ObservableCollection<Game> Games { get; set; } = games;

    public LibraryViewTypeModel() : this(null, null, LibraryViewType.Grid)
    {
    }
}