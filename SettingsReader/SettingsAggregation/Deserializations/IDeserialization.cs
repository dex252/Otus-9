namespace SettingsReader.SettingsAggregation.Deserializations
{
    public interface IDeserialization
    {
        T Deserialize<T>(string text);
    }
}
