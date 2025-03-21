using Avalonia.ReactiveUI;
using HexLaunch.ViewModels;
using ReactiveUI;

namespace HexLaunch.Views.Partials;

public partial class LibraryView : ReactiveUserControl<LibraryViewModel>
{
    public LibraryView()
    {
        this.WhenActivated(_ => { });
        InitializeComponent();
    }
}