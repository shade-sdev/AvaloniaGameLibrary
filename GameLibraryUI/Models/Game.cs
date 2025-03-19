using System.Collections.ObjectModel;

namespace GameLibraryUI.Models;

public class Game
{
    public          int    Id          { get; set; }
    public required string Title       { get; set; }
    public required string ImageSource { get; set; }
}

public class GamePage
{
    public ObservableCollection<Game> Games { get; set; } = [];
}