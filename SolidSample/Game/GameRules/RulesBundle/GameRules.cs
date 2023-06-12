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
                throw new Exception("Игровые правила не заданы для текущей игровой ситуации");
            }

            if (gameRules.Count() == 1)
            {
                return gameRules;
            }

            var hightPriority = gameRules.Where(e => e.IsHightPriority());
            if (hightPriority.Any())
            {
                return hightPriority;
            }

            return gameRules;
        }
    }
}
