using Avalonia.ReactiveUI;
using HexLaunch.ViewModels;
using ReactiveUI;

namespace HexLaunch.Views.Partials;

public partial class LibraryGridView : ReactiveUserControl<LibraryViewTypeModel>
{
    public LibraryGridView()
    {
        this.WhenActivated(_ => { });
        InitializeComponent();
    }
}