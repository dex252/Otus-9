using SolidSample.Models;

namespace SolidSample.Game.GameRules.OneRule
{
    internal interface IGameRule
    {
        /// <summary>
        /// Выполнить действия, соответствующие текущей игровой ситуации
        /// </summary>
        /// <returns></returns>
        Task Execute();

        /// <summary>
        /// Проверить, соответствует ли данное правило текущей игровой ситуации
        /// </summary>
        /// <param name="gameState"></param>
        /// <returns></returns>
        bool IsValid(ActualGameState gameState);
    }
}
