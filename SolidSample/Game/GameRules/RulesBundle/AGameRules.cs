using SolidSample.Game.GameRules.OneRule;

namespace SolidSample.Game.GameRules.RulesBundle
{
    internal abstract class AGameRules
    {
        public List<IGameRule> GameRulesList { get; }

        public AGameRules()
        {
            GameRulesList = new List<IGameRule>();
        }
    }
}
