using System;
using System.Globalization;
using AsepriteSharp.Models;

namespace AsepriteSharp.Converters
{
    /// <summary>
    /// Handles conversion of RGB(A) strings.
    /// </summary>
    public static class RgbaConverter
    {
        /// <summary>
        /// Decode values from an RGB(A) string. The input format is either #RRGGBB or #RRGGBBAA. 
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the input data is not the correct format.</exception>
        /// <exception cref="ArgumentNullException">Thrown when the input data is null.</exception>
        public static Rgba Decode(string data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));
            
            if (data.StartsWith("#"))
                data = data.Substring(1);

            switch (data.Length)
            {
                case 6:
                    return new Rgba
                    {
                        R = int.Parse(data.Substring(0, 2), NumberStyles.HexNumber),
                        G = int.Parse(data.Substring(2, 2), NumberStyles.HexNumber),
                        B = int.Parse(data.Substring(4, 2), NumberStyles.HexNumber),
                        A = 255
                    };
                case 8:
                    return new Rgba
                    {
                        R = int.Parse(data.Substring(0, 2), NumberStyles.HexNumber),
                        G = int.Parse(data.Substring(2, 2), NumberStyles.HexNumber),
                        B = int.Parse(data.Substring(4, 2), NumberStyles.HexNumber),
                        A = int.Parse(data.Substring(6, 2), NumberStyles.HexNumber)
                    };
                default:
                    throw new ArgumentException(
                        "Color component must be either 6 or 8 characters long (with or without the hash symbol.)",
                        nameof(data));
            }
        }

        /// <summary>
        /// Encodes values to an RGBA string.
        /// </summary>
        public static string Encode(Rgba color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}{color.A:X2}";
        }
    }
}