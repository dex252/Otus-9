using SolidSample.Models;
using SettingsReader;
using SettingsReader.SettingsAggregation.Readers;
using SettingsReader.SettingsAggregation.Deserializations;

namespace SolidSample
{
    internal class Program
    {
        const string SETTINGS_FILE_NAME = "settings.json";

        static void Main(string[] args)
        {
            IReader reader = new FileReader(SETTINGS_FILE_NAME);
            IDeserialization deserializator = new JsonDeserializer();
            var settingsAggregator = new SettingsAggregator<Settings>(reader, deserializator);
            var settings = settingsAggregator.GetSettings();

            Console.WriteLine("Hello, World!");
        }
    }
}