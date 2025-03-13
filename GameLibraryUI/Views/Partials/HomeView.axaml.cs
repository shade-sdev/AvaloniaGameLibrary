using Avalonia.ReactiveUI;
using GameLibraryUI.ViewModels;
using ReactiveUI;

namespace GameLibraryUI.Views.Partials;

public partial class HomeView : ReactiveUserControl<HomeViewModel>
{
    public HomeView()
    {
        this.WhenActivated(_ => { });
        InitializeComponent();
    }
}