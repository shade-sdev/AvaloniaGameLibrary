using Avalonia.ReactiveUI;
using HexLaunch.ViewModels;

namespace HexLaunch.Views.Partials;

public partial class GameView : ReactiveUserControl<GameViewModel>
{
    public GameView()
    {
        InitializeComponent();
    }
}