using SolidSample.Game.GameRules.OneRule;

namespace SolidSample.Game.GameRules.Aggregate
{
    internal interface IRulesAggregate
    {
        /// <summary>
        /// Заполнить игровую логику правилами
        /// </summary>
        /// <param name="rules"></param>
        void FillRules(IEnumerable<IGameRule> rules);
    }
}
