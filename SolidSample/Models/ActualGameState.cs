using SolidSample.Enums;

namespace SolidSample.Models
{
    public class ActualGameState
    {/// <summary>
     /// Текущее состояние игрового процесса
     /// </summary>
        public GameState State { get; set; }

        /// <summary>
        /// Выбранное пользователем число
        /// </summary>
        public int? CurrentNumber { get; set; }
    }
}
