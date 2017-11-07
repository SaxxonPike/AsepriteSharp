using AsepriteSharp.Models;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace AsepriteSharp
{
    /// <inheritdoc />
    [UsedImplicitly(ImplicitUseTargetFlags.Members)]
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