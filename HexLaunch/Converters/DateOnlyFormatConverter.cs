using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace HexLaunch.Converters;

public class DateOnlyFormatConverter : IValueConverter
{
    public static readonly DateOnlyFormatConverter Instance = new();

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is DateOnly dateOnly)
        {
            return dateOnly.ToString("yyyy-MM-dd");
        }

        return string.Empty;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}