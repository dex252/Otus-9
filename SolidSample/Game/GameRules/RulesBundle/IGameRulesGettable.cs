using SolidSample.Game.GameRules.OneRule;
using SolidSample.Models;

namespace SolidSample.Game.GameRules.RulesBundle
{
    internal interface IGameRulesGettable
    {
        /// <summary>
        /// Получить игровые правила, удовлетворяющие условиям текущего игрового процесса
        /// </summary>
        /// <param name="gameState"></param>
        /// <returns></returns>
        IEnumerable<IGameRule> GetRules(ActualGameState gameState);
    }
}
