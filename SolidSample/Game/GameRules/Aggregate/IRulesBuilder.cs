using SolidSample.Game.GameRules.RulesDefinitions.Rules;

namespace SolidSample.Game.GameRules.Aggregate
{
    internal interface IRulesBuilder
    {
        /// <summary>
        /// Получить правила на основе настроек игры
        /// </summary>
        /// <returns></returns>
        IEnumerable<IRuleSetter> GetRules();
    }
}
