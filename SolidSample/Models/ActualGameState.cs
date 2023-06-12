using SolidSample.Enums;

namespace SolidSample.Models
{
    public class ActualGameState
    {
        /// <summary>
        /// Текущее состояние игрового процесса
        /// </summary>
        public GameState State { get; set; }

        /// <summary>
        /// Выбранное пользователем число
        /// </summary>
        public int? PlayerNumber { get; set; }

        /// <summary>
        /// Загаданное компьютером число
        /// </summary>
        public int? ComputerNumber { get; set; }

        /// <summary>
        /// Число попыток угадать число
        /// </summary>
        public int? TryCount { get; set;}
    }
}
