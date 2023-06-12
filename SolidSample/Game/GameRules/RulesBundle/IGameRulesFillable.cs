using SolidSample.Game.GameRules.OneRule;

namespace SolidSample.Game.GameRules.RulesBundle
{
    internal interface IGameRulesFillable
    {
        /// <summary>
        /// Добавить игровое правило
        /// </summary>
        /// <param name="gameRule"></param>
        void AddRule(IGameRule gameRule);
    }
}
