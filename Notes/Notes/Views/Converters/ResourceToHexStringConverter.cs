﻿using System;
using System.Diagnostics;
using System.Globalization;
using Xamarin.Forms;

namespace Notes.Views.Converters
{

    public class ResourceToHexStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return Color.Default;

            string valueAsString = value.ToString();
            Debug.WriteLine(valueAsString);
            switch (valueAsString)
            {
                case (""):
                    {
                        return string.Empty;
                    }
                default:
                    {
                        var c = LookupColor(valueAsString);

                        return $"{ c.ToHex().ToString() }";
                    }
            }
        }

        public Color LookupColor(string key)
        {
            try
            {
                Application.Current.Resources.TryGetValue(key, out var newColor);
                return (newColor == null) ? Color.Black : (Color)newColor;
            }
            catch
            {
                return Color.White;
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}