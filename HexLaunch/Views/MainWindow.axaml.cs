using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using HexLaunch.ViewModels;
using ReactiveUI;

namespace HexLaunch.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        this.WhenActivated(_ => { });
        AvaloniaXamlLoader.Load(this);
    }


    private void OnWindowDrag(object? sender, PointerPressedEventArgs e)
    {
        if (e.GetCurrentPoint(this).Properties.IsLeftButtonPressed)
        {
            BeginMoveDrag(e);
        }
    }
}