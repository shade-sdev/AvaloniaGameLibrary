using Avalonia;
using Avalonia.Controls;
using Material.Icons;

namespace HexLaunch.Controls;

public partial class IconTextBadge : UserControl
{
    public static readonly StyledProperty<string> TextProperty =
        AvaloniaProperty.Register<IconTextBadge, string>(nameof(Text));

    public static readonly StyledProperty<MaterialIconKind> IconKindProperty =
        AvaloniaProperty.Register<IconTextBadge, MaterialIconKind>(nameof(IconKind));

    public string Text
    {
        get => GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public MaterialIconKind IconKind
    {
        get => GetValue(IconKindProperty);
        set => SetValue(IconKindProperty, value);
    }

    public IconTextBadge()
    {
        InitializeComponent();
    }
}