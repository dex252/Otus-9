using SolidSample.Game.GameRules.RulesDefinitions.Rules;
using SolidSample.Models;

namespace SolidSample.Game.GameRules.Aggregate
{
    internal class RulesBuilder: IRulesBuilder
    {
        Settings Settings { get; }

        public RulesBuilder(Settings settings)
        {
            Settings = settings;
        }

        public IEnumerable<IRuleSetter> GetRules()
        {
            var rulesBundle = new List<IRuleSetter>()
            {
                new FinishGameRule(Settings),
                new EndOfTryCountRule(Settings),
                new WrongNumberGameRule(Settings),
                new StartGameRule(Settings),
                new LessThenRule(Settings),
                new MoreThenRule(Settings),
            };

            return rulesBundle;
        }
    }
}
