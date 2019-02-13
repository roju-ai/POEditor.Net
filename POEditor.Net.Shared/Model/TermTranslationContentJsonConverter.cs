using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Model
{
    public class TermTranslationContentJsonConverter : JsonConverter<TermTranslationContent>
    {
        public override TermTranslationContent ReadJson(JsonReader reader, Type objectType, TermTranslationContent existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            existingValue = existingValue ?? new TermTranslationContent();
            if (reader.ValueType == typeof(string))
                existingValue.Value = serializer.Deserialize<string>(reader);
            else
                existingValue.KeyValues = serializer.Deserialize<Dictionary<string, string>>(reader);

            return existingValue;
        }

        public override void WriteJson(JsonWriter writer, TermTranslationContent value, JsonSerializer serializer)
        {
            if (value.KeyValues != null && value.KeyValues.Count > 0)
                serializer.Serialize(writer, value.KeyValues);
            else
                serializer.Serialize(writer, value.Value);
        }
    }
}
