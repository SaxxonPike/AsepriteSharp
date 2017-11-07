using AsepriteSharp.Models;

namespace AsepriteSharp
{
    /// <summary>
    /// Converts a sprite sheet to and from JSON.
    /// </summary>
    public interface ISheetConverter
    {
        /// <summary>
        /// Convert JSON to a sprite sheet.
        /// </summary>
        Sheet Decode(string json);
        
        /// <summary>
        /// Convert a sprite sheet to JSON.
        /// </summary>
        string Encode(Sheet sheet);
    }
}