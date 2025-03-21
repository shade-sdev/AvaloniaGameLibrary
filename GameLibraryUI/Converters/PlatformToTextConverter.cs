using System;
using System.Globalization;
using Avalonia.Data.Converters;
using GameLibraryUI.Models;

namespace GameLibraryUI.Converters;

public class PlatformToTextConverter : IValueConverter
{
    public static readonly PlatformToTextConverter Instance = new();


    public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value switch
               {
                   GamePlatFormType.Pc          => "PC",
                   GamePlatFormType.Xbox        => "Series X|S",
                   GamePlatFormType.PlayStation => "PS5",
                   _                            => "Unknown"
               };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        throw new NotImplementedException();
}