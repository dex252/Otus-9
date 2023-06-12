using Newtonsoft.Json;

namespace SettingsReader.SettingsAggregation.Deserializations
{
    public class JsonDeserializer : IDeserialization
    {
        public T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
