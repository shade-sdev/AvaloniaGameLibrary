using Avalonia.ReactiveUI;
using GameLibraryUI.ViewModels;

namespace GameLibraryUI.Views.Partials;

public partial class GameView : ReactiveUserControl<GameViewModel>
{
    public GameView()
    {
        InitializeComponent();
    }
}