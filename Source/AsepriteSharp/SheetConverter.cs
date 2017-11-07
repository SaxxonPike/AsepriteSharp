using AsepriteSharp.Models;
using Newtonsoft.Json;

namespace AsepriteSharp
{
    /// <inheritdoc />
    public class SheetConverter : ISheetConverter
    {
        public Sheet Decode(string json)
        {
            return JsonConvert.DeserializeObject<Sheet>(json);
        }

        public string Encode(Sheet sheet)
        {
            return JsonConvert.SerializeObject(sheet);
        }
    }
}