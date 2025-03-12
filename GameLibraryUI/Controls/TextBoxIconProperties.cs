using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Material.Icons;

namespace GameLibraryUI.Controls;

public static class TextBoxIconProperties
{
    public static readonly AttachedProperty<MaterialIconKind> IconKindProperty =
        AvaloniaProperty.RegisterAttached<Control, MaterialIconKind>(
            "IconKind", typeof(TextBoxIconProperties));

    public static MaterialIconKind GetIconKind(Control element)
    {
        return element.GetValue(IconKindProperty);
    }

    public static void SetIconKind(Control element, MaterialIconKind value)
    {
        element.SetValue(IconKindProperty, value);
    }

    public static readonly AttachedProperty<double> IconHeightProperty =
        AvaloniaProperty.RegisterAttached<Control, double>(
            "IconHeight", typeof(TextBoxIconProperties), 20.0); // Default value

    public static double GetIconHeight(Control element)
    {
        return element.GetValue(IconHeightProperty);
    }

    public static void SetIconHeight(Control element, double value)
    {
        element.SetValue(IconHeightProperty, value);
    }

    public static readonly AttachedProperty<double> IconWidthProperty =
        AvaloniaProperty.RegisterAttached<Control, double>(
            "IconWidth", typeof(TextBoxIconProperties), 20.0); // Default value

    public static double GetIconWidth(Control element)
    {
        return element.GetValue(IconWidthProperty);
    }

    public static void SetIconWidth(Control element, double value)
    {
        element.SetValue(IconWidthProperty, value);
    }

    public static readonly AttachedProperty<IBrush> IconForegroundProperty =
        AvaloniaProperty.RegisterAttached<Control, IBrush>(
            "IconForeground", typeof(TextBoxIconProperties), Brushes.Red); // Default value

    public static IBrush GetIconForeground(Control element)
    {
        return element.GetValue(IconForegroundProperty);
    }

    public static void SetIconForeground(Control element, IBrush value)
    {
        element.SetValue(IconForegroundProperty, value);
    }

    public static readonly AttachedProperty<Thickness> IconMarginProperty =
        AvaloniaProperty.RegisterAttached<Control, Thickness>(
            "IconMargin", typeof(TextBoxIconProperties), new Thickness(0, 0, 5, 0)); // Default value

    public static Thickness GetIconMargin(Control element)
    {
        return element.GetValue(IconMarginProperty);
    }

    public static void SetIconMargin(Control element, Thickness value)
    {
        element.SetValue(IconMarginProperty, value);
    }
}