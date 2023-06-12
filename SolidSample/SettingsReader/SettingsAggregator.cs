using SettingsReader.SettingsAggregation.Deserializations;
using SettingsReader.SettingsAggregation.Readers;

namespace SettingsReader
{
    public class SettingsAggregator<T>
    {
        public IReader Reader { get; }
        public IDeserialization Deserializator { get; }

        public SettingsAggregator(IReader reader, IDeserialization deserializator)
        {
            Reader = reader;
            Deserializator = deserializator;
        }

        public T GetSettings()
        {
            var resource = Reader.ReadResource();
            return Deserializator.Deserialize<T>(resource);
        }
    }
}
