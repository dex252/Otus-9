using SolidSample.Game.GameRules.OneRule;

namespace SolidSample.Game.GameRules.RulesDefinitions
{
    public interface IRuleDefinition
    {
        /// <summary>
        /// Получить список правил для игры
        /// </summary>
        /// <returns></returns>
        IEnumerable<IGameRule> GetRules();
    }
}
