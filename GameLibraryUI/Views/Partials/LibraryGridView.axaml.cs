using Avalonia.ReactiveUI;
using GameLibraryUI.ViewModels;
using ReactiveUI;

namespace GameLibraryUI.Views.Partials;

public partial class LibraryGridView : ReactiveUserControl<LibraryViewTypeModel>
{
    public LibraryGridView()
    {
        this.WhenActivated(_ => { });
        InitializeComponent();
    }
}