using System;
using System.Collections.ObjectModel;
using System.Globalization;
using HexLaunch.Models;

namespace HexLaunch.Services;

public static class GameService
{
    public static readonly ObservableCollection<Game> Games =
    [
        new()
        {
            Id    = 1,
            Title = "Grand Theft Auto VI",
            Description =
                "Grand Theft Auto VI heads to the state of Leonida, home to the neon-soaked streets of Vice City and beyond in the biggest, most immersive evolution of the Grand Theft Auto series yet.",
            ImageSource      = "https://images.igdb.com/igdb/image/upload/t_cover_big/co7gdk.webp",
            CoverImageSource = "https://images.igdb.com/igdb/image/upload/t_1080p/ar2nxz.webp",
            Screenshots =
            [
                "https://images.igdb.com/igdb/image/upload/t_720p/scpsp7.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/scpsp6.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/scpsp9.webp"
            ],
            GamePlatFormTypes = [GamePlatFormType.PlayStation, GamePlatFormType.Xbox],
            Developer         = "Rockstar Games",
            Manufacturer      = "Take-Two Interactive",
            Genre             = "Shooter",
            ReleaseDate       = DateOnly.Parse("2021-10-17", CultureInfo.InvariantCulture),
            Rating            = 5
        },

        new()
        {
            Id          = 1,
            Title       = "Assassin's Creed Shadows",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co87cu.webp",
            Description =
                "Experience an epic historical action-adventure story set in feudal Japan! Become a lethal shinobi Assassin and a powerful legendary samurai as you explore a beautiful open world in a time of chaos. Switch seamlessly between two unlikely allies as you discover their common destiny. Master complementary playstyles, create your shinobi league, customize your hideout, and usher in a new era for Japan.",
            CoverImageSource = "https://images.igdb.com/igdb/image/upload/t_1080p/ar2xdm.webp",
            Screenshots =
            [
                "https://images.igdb.com/igdb/image/upload/t_720p/scta09.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/scs6j4.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/scs6j5.webp"
            ],
            GamePlatFormTypes = [GamePlatFormType.Pc, GamePlatFormType.Xbox, GamePlatFormType.PlayStation],
            Developer         = "Ubisoft Québec",
            Manufacturer      = "Ubisoft Entertainment",
            Genre             = "Role-playing (RPG), Adventure",
            ReleaseDate       = DateOnly.Parse("2021-10-17", CultureInfo.InvariantCulture),
            Rating            = 1
        },

        new()
        {
            Id          = 1,
            Title       = "Clair Obscur: Expedition 33",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co9gam.webp",
            Description =
                "Lead the members of Expedition 33 on their quest to destroy the Paintress so that she can never paint death again. Explore a world of wonders inspired by Belle Époque France and battle unique enemies in this turn-based RPG with real-time mechanics.",
            CoverImageSource = "https://images.igdb.com/igdb/image/upload/t_1080p/ar2zir.webp",
            Screenshots =
            [
                "https://images.igdb.com/igdb/image/upload/t_720p/scsodz.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/scsoe8.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/scsoec.webp"
            ],
            GamePlatFormTypes = [GamePlatFormType.Pc, GamePlatFormType.Xbox, GamePlatFormType.PlayStation],
            Developer         = "Sandfall Interactive",
            Manufacturer      = "Kepler Interactive",
            Genre             = "Role-playing (RPG)",
            ReleaseDate       = DateOnly.Parse("2021-10-17", CultureInfo.InvariantCulture),
            Rating            = 3
        },

        new()
        {
            Id          = 1,
            Title       = "Death Stranding 2: On The Beach",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co9ipx.webp",
            Description =
                "Embark on an inspiring mission of human connection beyond the UCA. Sam — with companions by his side — sets out on a new journey to save humanity from extinction. Join them as they traverse a world beset by otherworldly enemies, obstacles and a haunting question: should we have connected?",
            CoverImageSource = "https://images.igdb.com/igdb/image/upload/t_1080p/scka9g.webp",
            Screenshots =
            [
                "https://images.igdb.com/igdb/image/upload/t_720p/scka9j.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/scka9k.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/scqbvr.webp"
            ],
            GamePlatFormTypes = [GamePlatFormType.Pc, GamePlatFormType.Xbox, GamePlatFormType.PlayStation],
            Developer         = "Kojima Productions",
            Manufacturer      = "Sony Interactive Entertainment",
            Genre             = "Shooter, Adventure",
            ReleaseDate       = DateOnly.Parse("2021-10-17", CultureInfo.InvariantCulture),
            Rating            = 5
        },

        new()
        {
            Id          = 1,
            Title       = "Doom: The Dark Ages",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co9b3o.webp",
            Description =
                "DOOM: The Dark Ages is the prequel to the critically acclaimed DOOM (2016) and DOOM Eternal that tells the epic cinematic origin story of the DOOM Slayer’s rage. Players will step into the blood-stained boots of the DOOM Slayer, in this never-before-seen dark and sinister medieval war against Hell.",
            CoverImageSource = "https://images.igdb.com/igdb/image/upload/t_1080p/ar2zix.webp",
            Screenshots =
            [
                "https://images.igdb.com/igdb/image/upload/t_720p/scsofy.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/scsofl.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/scsofz.webp"
            ],
            GamePlatFormTypes = [GamePlatFormType.Pc, GamePlatFormType.Xbox, GamePlatFormType.PlayStation],
            Developer         = "id Software",
            Manufacturer      = "Bethesda Softworks",
            Genre             = "Shooter",
            ReleaseDate       = DateOnly.Parse("2021-10-17", CultureInfo.InvariantCulture),
            Rating            = 5
        },

        new()
        {
            Id          = 1,
            Title       = "Uncharted: The Lost Legacy",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1tp9.webp",
            Description =
                "From the critically acclaimed developer, Naughty Dog, comes the first standalone adventure in the Uncharted series. Fan-favorite character, Chloe Frazer, must enlist the aid of renowned mercenary Nadine Ross from Uncharted 4: A Thief’s End in order to recover a fabled ancient Indian artifact and keep it out of the hands of a ruthless war profiteer. Together, they’ll venture deep into the mountains of India in search of the legendary artifact. Along the way, they’ll learn to work together to unearth the mystery of the artifact, fight their way through fierce opposition, and prevent the region from falling into chaos.",
            CoverImageSource = "https://images.igdb.com/igdb/image/upload/t_1080p/ar4v9.webp",
            Screenshots =
            [
                "https://images.igdb.com/igdb/image/upload/t_720p/pt8at6qekuxyvibtbnop.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/elkqgnmjz6vg4sxy1dwt.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/v2bvkazlfe8fcttuxqxu.webp"
            ],
            GamePlatFormTypes = [GamePlatFormType.Pc, GamePlatFormType.Xbox, GamePlatFormType.PlayStation],
            Developer         = "Naughty Dog",
            Manufacturer      = "Sony Interactive Entertainment",
            Genre             = "Shooter, Puzzle, Adventure",
            ReleaseDate       = DateOnly.Parse("2021-10-17", CultureInfo.InvariantCulture),
            Rating            = 3
        },

        new()
        {
            Id          = 1,
            Title       = "Revenant: In Memory Of The Day",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co9i2c.webp",
            Description =
                "You are heading down an endless corridor in search of a missing child. Pay close attention to your surroundings to find clues about the child, and find a way to escape the dark, confined corridor.",
            CoverImageSource = "https://images.igdb.com/igdb/image/upload/t_1080p/ar3ch6.webp",
            Screenshots =
            [
                "https://images.igdb.com/igdb/image/upload/t_720p/scvner.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/scvnez.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/scvnf3.webp"
            ],
            GamePlatFormTypes = [GamePlatFormType.Pc, GamePlatFormType.Xbox, GamePlatFormType.PlayStation],
            Developer         = "",
            Manufacturer      = "",
            Genre             = "Simulator, Adventure, Indie",
            ReleaseDate       = DateOnly.Parse("2021-10-17", CultureInfo.InvariantCulture),
            Rating            = 4
        },

        new()
        {
            Id          = 1,
            Title       = "Fable",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co8bop.webp",
            Description =
                "The adventure in which you are about to embark tells the story of how once upon a time a young boy named Quickthorpe set out a journey through the lost world of Balkhane. It is a Fable in one way, but in the 'trick of the tale', it's a strange adventure through a shattered world and a saga born out of the very sick mind of a man called Ismael.",
            CoverImageSource = "https://images.igdb.com/igdb/image/upload/t_1080p/ar2ziv.webp",
            Screenshots =
            [
                "https://images.igdb.com/igdb/image/upload/t_720p/scsoet.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/scsoez.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/scsoey.webp"
            ],
            GamePlatFormTypes = [GamePlatFormType.Pc, GamePlatFormType.Xbox, GamePlatFormType.PlayStation],
            Developer         = "Simbiosis Interactive",
            Manufacturer      = "Telstar Electronic Studios Ltd.\nSir-tech Software",
            Genre             = "Puzzle, Role-playing (RPG), Adventure",
            ReleaseDate       = DateOnly.Parse("2021-10-17", CultureInfo.InvariantCulture),
            Rating            = 1
        },

        new()
        {
            Id          = 1,
            Title       = "Mafia: The Old Country",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co8pfn.webp",
            Description =
                "Uncover the origins of organized crime in Mafia: The Old Country, a gritty mob story set in the brutal underworld of 1900s Sicily.",
            CoverImageSource = "https://images.igdb.com/igdb/image/upload/t_1080p/sctojm.webp",
            Screenshots =
            [
                "https://images.igdb.com/igdb/image/upload/t_720p/sctojq.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/sctojo.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/sctojp.webp"
            ],
            GamePlatFormTypes = [GamePlatFormType.Pc, GamePlatFormType.Xbox, GamePlatFormType.PlayStation],
            Developer         = "Hangar 13",
            Manufacturer      = "2K",
            Genre             = "Shooter, Adventure",
            ReleaseDate       = DateOnly.Parse("2021-10-17", CultureInfo.InvariantCulture),
            Rating            = 5
        },

        new()
        {
            Id          = 1,
            Title       = "Ghost of Yotei",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co9coo.webp",
            Description =
                "The game takes place 300 years after Ghost of Tsushima. Set in the lands surrounding Mount Yōtei, a towering peak in the heart of Ezo, an area of Japan known as Hokkaido in present day.",
            CoverImageSource = "https://images.igdb.com/igdb/image/upload/t_1080p/sctzwq.webp",
            Screenshots =
            [
                "https://images.igdb.com/igdb/image/upload/t_720p/sctzwq.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/sctzwt.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/sctzww.webp"
            ],
            GamePlatFormTypes = [GamePlatFormType.Pc, GamePlatFormType.Xbox, GamePlatFormType.PlayStation],
            Manufacturer      = "Sony Interactive Entertainment",
            Developer         = "Sucker Punch Productions",
            Genre             = "Role Playing",
            ReleaseDate       = DateOnly.Parse("2021-10-17", CultureInfo.InvariantCulture),
            Rating            = 4.8
        },

        new()
        {
            Id          = 1,
            Title       = "Baldur's Gate 3",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co670h.webp",
            Description =
                "An ancient evil has returned to Baldur's Gate, intent on devouring it from the inside out. The fate of Faerun lies in your hands. Alone, you may resist. But together, you can overcome.",
            CoverImageSource = "https://images.igdb.com/igdb/image/upload/t_1080p/ar261f.webp",
            Screenshots =
            [
                "https://images.igdb.com/igdb/image/upload/t_720p/sc81fh.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/sc81fg.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/sc81fn.webp"
            ],
            GamePlatFormTypes = [GamePlatFormType.Pc, GamePlatFormType.Xbox, GamePlatFormType.PlayStation],
            Developer         = "Larian Studios",
            Manufacturer      = "Larian Studios",
            Genre             = "Role-playing (RPG), Strategy, Turn-based strategy (TBS), Tactical, Adventure",
            ReleaseDate       = DateOnly.Parse("2021-10-17", CultureInfo.InvariantCulture),
            Rating            = 4.9
        },

        new()
        {
            Id          = 1,
            Title       = "Persona 5 Royal",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1nic.webp",
            Description =
                "An enhanced version of Persona 5 with some new characters and a third semester added to the game. Released Internationally in 2020.",
            CoverImageSource = "https://images.igdb.com/igdb/image/upload/t_1080p/ar616.webp",
            Screenshots =
            [
                "https://images.igdb.com/igdb/image/upload/t_720p/sc6vq2.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/sc6vps.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/sc6vq1.webp"
            ],
            GamePlatFormTypes = [GamePlatFormType.Pc, GamePlatFormType.Xbox, GamePlatFormType.PlayStation],
            Developer         = "Atlus",
            Manufacturer      = "Sega",
            Genre             = "Role-playing (RPG), Turn-based strategy (TBS), Adventure",
            ReleaseDate       = DateOnly.Parse("2021-10-17", CultureInfo.InvariantCulture),
            Rating            = 5
        },

        new()
        {
            Id          = 1,
            Title       = "The Witcher 3: Wild Hunt",
            ImageSource = "https://images.igdb.com/igdb/image/upload/t_cover_big/co1wyy.webp",
            Description =
                "RPG and sequel to The Witcher 2 (2011), The Witcher 3 follows witcher Geralt of Rivia as he seeks out his former lover and his young subject while intermingling with the political workings of the wartorn Northern Kingdoms. Geralt has to fight monsters and deal with people of all sorts in order to solve complex problems and settle contentious disputes, each ranging from the personal to the world-changing.",
            CoverImageSource = "https://images.igdb.com/igdb/image/upload/t_1080p/pwhylsl5nx0bgj5lz2ok.webp",
            Screenshots =
            [
                "https://images.igdb.com/igdb/image/upload/t_720p/farvemmmxav0bgt6wx7t.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/usxccsncekxg0wd1v6ee.webp",
                "https://images.igdb.com/igdb/image/upload/t_720p/sciabd.webp"
            ],
            GamePlatFormTypes = [GamePlatFormType.Pc, GamePlatFormType.Xbox, GamePlatFormType.PlayStation],
            Developer         = "CD Projekt RED",
            Manufacturer      = "WB Games",
            Genre             = "Role-playing (RPG), Adventure",
            ReleaseDate       = DateOnly.Parse("2021-10-17", CultureInfo.InvariantCulture),
            Rating            = 5
        }
    ];
}