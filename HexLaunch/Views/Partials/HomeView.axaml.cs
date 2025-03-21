using Avalonia.ReactiveUI;
using HexLaunch.ViewModels;
using ReactiveUI;

namespace HexLaunch.Views.Partials;

public partial class HomeView : ReactiveUserControl<HomeViewModel>
{
    public HomeView()
    {
        this.WhenActivated(_ => { });
        InitializeComponent();
    }
}