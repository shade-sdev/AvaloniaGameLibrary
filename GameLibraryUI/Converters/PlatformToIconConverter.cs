using System;
using System.Globalization;
using Avalonia.Data.Converters;
using GameLibraryUI.Models;

namespace GameLibraryUI.Converters;

public class PlatformToIconConverter : IValueConverter
{
    public static readonly PlatformToIconConverter Instance = new();

    public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value switch
               {
                   GamePlatFormType.Pc          => "MicrosoftWindows",
                   GamePlatFormType.Xbox        => "XboxLive",
                   GamePlatFormType.PlayStation => "SonyPlaystation",
                   _                            => "HelpCircle" // Default icon
               };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        throw new NotImplementedException();
}