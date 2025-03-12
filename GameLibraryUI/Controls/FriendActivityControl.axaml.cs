using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GameLibraryUI.Controls;

public partial class FriendActivityControl : UserControl
{
    public static readonly StyledProperty<string> UserAvatarUrlProperty =
        AvaloniaProperty.Register<FriendActivityControl, string>(nameof(UserAvatarUrl));

    public static readonly StyledProperty<string> UsernameProperty =
        AvaloniaProperty.Register<FriendActivityControl, string>(nameof(Username));

    public static readonly StyledProperty<string> GameNameProperty =
        AvaloniaProperty.Register<FriendActivityControl, string>(nameof(GameName));

    public string UserAvatarUrl
    {
        get => GetValue(UserAvatarUrlProperty);
        set => SetValue(UserAvatarUrlProperty, value);
    }

    public string Username
    {
        get => GetValue(UsernameProperty);
        set => SetValue(UsernameProperty, value);
    }

    public string GameName
    {
        get => GetValue(GameNameProperty);
        set => SetValue(GameNameProperty, value);
    }

    public FriendActivityControl()
    {
        InitializeComponent();
    }
    
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}