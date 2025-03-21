using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using HexLaunch.ViewModels;
using HexLaunch.Views;

namespace HexLaunch;

using MainWindow = MainWindow;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
                                 {
                                     DataContext = new MainWindowViewModel(),
                                 };
        }

        base.OnFrameworkInitializationCompleted();
    }
}