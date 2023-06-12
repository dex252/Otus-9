using SolidSample.Game.GameRules.OneRule;
using SolidSample.Game.GameRules.RulesBundle;
using SolidSample.Models;
using ConcretteGameRules = SolidSample.Game.GameRules.RulesBundle.GameRules;

namespace SolidSample.Game.Builders
{
    internal class GameBuilder : IGameBuilder
    {
        Settings Settings { get; }

        public GameBuilder(Settings settings)
        {
            Settings = settings;
        }

        public IGamesRules Build(ActualGameState actualGameState)
        {
            IGameRulesFillable gameRules = new ConcretteGameRules();
            //TODO:
            gameRules.AddRule(new GameRule(actualGameState));
            if (gameRules is IGamesRules)
            {
                return gameRules as IGamesRules;
            }

            throw new Exception("Не удалось привести игровые правила к базовому классу");
        }
    }
}
