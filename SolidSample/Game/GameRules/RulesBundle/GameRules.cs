using SolidSample.Game.GameRules.OneRule;
using SolidSample.Models;

namespace SolidSample.Game.GameRules.RulesBundle
{
    internal class GameRules : AGameRules, IGamesRules, IGameRulesFillable
    {
        public void AddRule(IGameRule gameRule)
        {
            GameRulesList.Append(gameRule);
        }

        public IEnumerable<IGameRule> GetRules(ActualGameState gameState)
        {
            var gameRules = GameRulesList.Where(rule => rule.IsValid(gameState));
            if (!gameRules.Any())
            {
                throw new Exception("игровые правила не заданы для текущей игровой ситуации");
            }

            return gameRules;
        }
    }
}
