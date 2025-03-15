using Avalonia.ReactiveUI;
using GameLibraryUI.ViewModels;
using ReactiveUI;

namespace GameLibraryUI.Views.Partials;

public partial class LibraryView : ReactiveUserControl<LibraryViewModel>
{
    public LibraryView()
    {
        this.WhenActivated(_ => { });
        InitializeComponent();
    }
}