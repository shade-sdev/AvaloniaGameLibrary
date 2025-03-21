using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Material.Icons;

namespace HexLaunch.Controls;

public partial class CircularIconButton : UserControl
{
    // Define Avalonia properties
    public static readonly StyledProperty<double> CircleSizeProperty =
        AvaloniaProperty.Register<CircularIconButton, double>(nameof(CircleSize), 40);

    public static readonly StyledProperty<double> IconSizeProperty =
        AvaloniaProperty.Register<CircularIconButton, double>(nameof(IconSize), 20);

    public static readonly StyledProperty<MaterialIconKind> KindProperty =
        AvaloniaProperty.Register<CircularIconButton, MaterialIconKind>(nameof(Kind), MaterialIconKind.Games);

    public static readonly StyledProperty<IBrush> BackgroundColorProperty =
        AvaloniaProperty.Register<CircularIconButton, IBrush>(nameof(BackgroundColor), Brushes.Aqua);

    public static readonly StyledProperty<IBrush> IconColorProperty =
        AvaloniaProperty.Register<CircularIconButton, IBrush>(nameof(IconColor),
                                                              new SolidColorBrush(Color.Parse("#e1324b")));

    public static readonly StyledProperty<ICommand> CommandProperty =
        AvaloniaProperty.Register<CircularIconButton, ICommand>(nameof(Command));

    public static readonly StyledProperty<object> CommandParameterProperty =
        AvaloniaProperty.Register<CircularIconButton, object>(nameof(CommandParameter));

    public static readonly StyledProperty<IBrush> HoverBackgroundColorProperty =
        AvaloniaProperty.Register<CircularIconButton, IBrush>(nameof(HoverBackgroundColor), Brushes.DarkGray);

    public static readonly StyledProperty<IBrush> PressedBackgroundColorProperty =
        AvaloniaProperty.Register<CircularIconButton, IBrush>(nameof(PressedBackgroundColor), Brushes.DimGray);

    // Property accessors
    public double CircleSize
    {
        get => GetValue(CircleSizeProperty);
        set => SetValue(CircleSizeProperty, value);
    }

    public double IconSize
    {
        get => GetValue(IconSizeProperty);
        set => SetValue(IconSizeProperty, value);
    }

    public MaterialIconKind Kind
    {
        get => GetValue(KindProperty);
        set => SetValue(KindProperty, value);
    }

    public IBrush BackgroundColor
    {
        get => GetValue(BackgroundColorProperty);
        set => SetValue(BackgroundColorProperty, value);
    }

    public IBrush IconColor
    {
        get => GetValue(IconColorProperty);
        set => SetValue(IconColorProperty, value);
    }

    public ICommand Command
    {
        get => GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    public object CommandParameter
    {
        get => GetValue(CommandParameterProperty);
        set => SetValue(CommandParameterProperty, value);
    }

    public IBrush HoverBackgroundColor
    {
        get => GetValue(HoverBackgroundColorProperty);
        set => SetValue(HoverBackgroundColorProperty, value);
    }

    public IBrush PressedBackgroundColor
    {
        get => GetValue(PressedBackgroundColorProperty);
        set => SetValue(PressedBackgroundColorProperty, value);
    }

    public CircularIconButton()
    {
        InitializeComponent();
    }
}