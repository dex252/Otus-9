using SolidSample.Models;
using SettingsReader;
using SettingsReader.SettingsAggregation.Readers;
using SettingsReader.SettingsAggregation.Deserializations;
using SolidSample.Game;
using SolidSample.Game.Builders;
using SolidSample.Game.GameRules.Validation;
using SolidSample.Game.GameRules.Aggregate;

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

            IRulesBuilder rulesBuilder = new RulesBuilder(settings);
            IRulesAggregate rulesAggregate = new RulesAggregate(rulesBuilder);
            IRulesValidator rulesValidator = new SingleRuleValidator(settings);

            IGameBuilder gameBuilder = new GameBuilder(rulesAggregate, rulesValidator);
            var game = new GameRunner(gameBuilder);
            await game.Run();
        }
    }
}