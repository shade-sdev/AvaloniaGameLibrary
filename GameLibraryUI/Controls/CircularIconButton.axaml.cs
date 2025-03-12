using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Material.Icons;

namespace GameLibraryUI.Controls;

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

    public CircularIconButton()
    {
        InitializeComponent();
    }

}