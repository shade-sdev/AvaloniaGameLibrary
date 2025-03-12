using Avalonia;
using Avalonia.Controls;

namespace GameLibraryUI.Controls;

public partial class InputBorderControl : UserControl
{
    
    public static readonly StyledProperty<string> TextProperty =
        AvaloniaProperty.Register<InputBorderControl, string>(nameof(Text));
    
    public string Text
    {
        get => GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }
    
    public InputBorderControl()
    {
        InitializeComponent();
    }
}