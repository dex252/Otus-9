using SolidSample.Models;

namespace SolidSample.Game.GameRules.OneRule
{
    public interface IGameRule
    {
        /// <summary>
        /// Выполнить действия, соответствующие текущей игровой ситуации
        /// </summary>
        /// <param name="gameState"></param>
        /// <returns></returns>
        Task Execute(ActualGameState gameState);

        /// <summary>
        /// Возвращает приоритет выполнения функции
        /// </summary>
        /// <returns></returns>
        bool IsHightPriority();

        /// <summary>
        /// Проверить, соответствует ли данное правило текущей игровой ситуации
        /// </summary>
        /// <param name="gameState"></param>
        /// <returns></returns>
        bool IsValid(ActualGameState gameState);
    }
}
