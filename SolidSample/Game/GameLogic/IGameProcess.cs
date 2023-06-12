namespace SolidSample.Game.GameLogic
{
    /// <summary>
    /// Управление игровым процессом
    /// </summary>
    internal interface IGameProcess
    {
        /// <summary>
        /// Выполнить следующее игровое действие
        /// </summary>
        /// <returns></returns>
        Task NextAction();

        /// <summary>
        /// Проверить, завершена ли игра
        /// </summary>
        /// <returns></returns>
        bool IsFinishGame();
    }
}
