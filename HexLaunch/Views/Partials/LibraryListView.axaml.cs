using Avalonia.ReactiveUI;
using HexLaunch.ViewModels;
using ReactiveUI;

namespace HexLaunch.Views.Partials;

public partial class LibraryListView : ReactiveUserControl<LibraryViewTypeModel>
{
    public LibraryListView()
    {
        this.WhenActivated(_ => { });
        InitializeComponent();
    }
}