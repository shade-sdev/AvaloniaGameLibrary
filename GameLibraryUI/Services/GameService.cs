using System.Collections.ObjectModel;
using GameLibraryUI.Models;

namespace GameLibraryUI.Services;

public static class GameService
{
    public static readonly ObservableCollection<Game> Games = new ObservableCollection<Game>
    {
        new Game
        {
            Id          = 1,
            Title       = "Grand Theft Auto VI",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co7gdk.webp"
        },
        new Game
        {
            Id          = 1,
            Title       = "Assassin's Creed Shadows",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co87cu.webp"
        },
        new Game
        {
            Id          = 1,
            Title       = "Clair Obscur: Expedition 33",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co9gam.webp"
        },
        new Game
        {
            Id          = 1,
            Title       = "Death Stranding 2: On The Beach",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co9ipx.webp"
        },
        new Game
        {
            Id          = 1,
            Title       = "Doom: The Dark Ages",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co9b3o.webp"
        },
        new Game
        {
            Id          = 1,
            Title       = "Uncharted: The Lost Legacy",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1tp9.webp"
        },
        new Game
        {
            Id          = 1,
            Title       = "Revenant: In Memory Of The Day",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co9i2c.webp"
        },
        new Game
        {
            Id          = 1,
            Title       = "Fable",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co8bop.webp"
        },
        new Game
        {
            Id          = 1,
            Title       = "Mafia: The Old Country",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co8pfn.webp"
        },
        new Game
        {
            Id          = 1,
            Title       = "Ghost of Yotei",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co9coo.webp"
        },
        new Game
        {
            Id          = 1,
            Title       = "Baldur's Gate 3",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co670h.webp"
        },
        new Game
        {
            Id          = 1,
            Title       = "Persona 5 Royal",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1nic.webp"
        },
        new Game
        {
            Id          = 1,
            Title       = "The Witcher 3: Wild Hunt",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1wyy.webp"
        }
    };
}