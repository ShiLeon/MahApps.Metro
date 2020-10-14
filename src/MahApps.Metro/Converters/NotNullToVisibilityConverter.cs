﻿using System;
using System.Globalization;
using System.Windows;

namespace MahApps.Metro.Converters
{
    [System.Windows.Data.ValueConversion(typeof(object), typeof(Visibility))]
    [System.Windows.Markup.MarkupExtensionReturnType(typeof(NotNullToVisibilityConverter))]
    public class NotNullToVisibilityConverter : MarkupConverter
    {
        NotNullToVisibilityConverter _instance;

        protected override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? Visibility.Collapsed : Visibility.Visible;
        }

        protected override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _instance ??= new NotNullToVisibilityConverter();
        }
    }
}