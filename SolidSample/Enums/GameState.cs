namespace SolidSample.Enums
{
    /// <summary>
    /// Текущее состояние игры
    /// </summary>
    public enum GameState
    {
        /// <summary>
        /// Запросить число
        /// </summary>
        START = 0,

        /// <summary>
        /// Продолжить игру
        /// </summary>
        PROCESS = 1,

        /// <summary>
        /// Завершить игру
        /// </summary>
        FINISH = 2
    }
}
