using System;
using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Media;

namespace GameLibraryUI.Converters;

public class ViewModelToForegroundConverter : IValueConverter
{
    public static readonly ViewModelToForegroundConverter Instance = new();

    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == null || parameter == null) return Brushes.Black;
        var viewModel       = value.GetType().Name;
        var targetViewModel = parameter.ToString();

        if (viewModel == targetViewModel)
        {
            return new SolidColorBrush(Color.Parse("#e1324b"));
        }

        return Brushes.LightGray;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}