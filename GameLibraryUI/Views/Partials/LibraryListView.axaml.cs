using Avalonia.ReactiveUI;
using GameLibraryUI.ViewModels;
using ReactiveUI;

namespace GameLibraryUI.Views.Partials;

public partial class LibraryListView : ReactiveUserControl<LibraryViewTypeModel>
{
    public LibraryListView()
    {
        this.WhenActivated(_ => { });
        InitializeComponent();
    }
}