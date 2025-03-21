using System.Reactive.Linq;
using Avalonia;
using Avalonia.Controls;
using ReactiveUI;

namespace HexLaunch.Controls;

public partial class GameProgressControl : UserControl
{
    public static readonly StyledProperty<string> GameTitleProperty =
        AvaloniaProperty.Register<GameProgressControl, string>(
                                                               nameof(GameTitle),
                                                               defaultValue: "Game Title");

    public string GameTitle
    {
        get => GetValue(GameTitleProperty);
        set => SetValue(GameTitleProperty, value);
    }

    // Progress Value Property (0-100)
    public static readonly StyledProperty<double> ProgressValueProperty =
        AvaloniaProperty.Register<GameProgressControl, double>(
                                                               nameof(ProgressValue),
                                                               defaultValue: 0.0);

    public double ProgressValue
    {
        get => GetValue(ProgressValueProperty);
        set => SetValue(ProgressValueProperty, value);
    }

    public static readonly StyledProperty<string> ProgressPercentageValueProperty =
        AvaloniaProperty.Register<GameProgressControl, string>(
                                                               nameof(ProgressPercentageValue),
                                                               defaultValue: "0%");


    public string ProgressPercentageValue
    {
        get => $"{GetValue(ProgressPercentageValueProperty)}%";
        set => SetValue(ProgressPercentageValueProperty, value);
    }


    // Game Image Source Property
    public static readonly StyledProperty<string> GameImageSourceProperty =
        AvaloniaProperty.Register<GameProgressControl, string>(
                                                               nameof(GameImageSource));

    public string GameImageSource
    {
        get => GetValue(GameImageSourceProperty);
        set => SetValue(GameImageSourceProperty, value);
    }

    public GameProgressControl()
    {
        InitializeComponent();

        this.WhenAnyValue(x => x.ProgressValue)
            .Select(value => $"{value}%")
            .BindTo(this, x => x.ProgressPercentageValue);
    }
}