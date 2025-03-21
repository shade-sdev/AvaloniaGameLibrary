using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HexLaunch.Models;

public class Game
{
    public          int                     Id                { get; set; }
    public required string                  Title             { get; set; }
    public          string?                 Description       { get; set; }
    public required string                  ImageSource       { get; set; }
    public          string?                 CoverImageSource  { get; set; }
    public          List<string>?           Screenshots       { get; set; }
    public          List<GamePlatFormType>? GamePlatFormTypes { get; set; }
    public          DateOnly?               ReleaseDate       { get; set; }
    public          string?                 Manufacturer      { get; set; }
    public          string?                 Developer         { get; set; }
    public          string?                 Genre             { get; set; }
    public          double?                 Rating            { get; set; }
}

public enum GamePlatFormType
{
    Pc,
    Xbox,
    PlayStation,
}

public class GamePage
{
    public ObservableCollection<Game> Games { get; set; } = [];
}