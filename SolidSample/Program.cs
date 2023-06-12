using SolidSample.Models;
using SettingsReader;
using SettingsReader.SettingsAggregation.Readers;
using SettingsReader.SettingsAggregation.Deserializations;
using SolidSample.Game;
using SolidSample.Game.Builders;

namespace SolidSample
{
    internal class Program
    {
        const string SETTINGS_FILE_NAME = "settings.json";

        static async Task Main(string[] args)
        {
            IReader reader = new FileReader(SETTINGS_FILE_NAME);
            IDeserialization deserializator = new JsonDeserializer();
            var settingsAggregator = new SettingsAggregator<Settings>(reader, deserializator);
            var settings = settingsAggregator.GetSettings();

            IGameBuilder gameBuilder = new GameBuilder(settings);
            var game = new GameRunner(gameBuilder);

            Console.WriteLine("Hello, World!");
            await game.Run();
        }
    }
}