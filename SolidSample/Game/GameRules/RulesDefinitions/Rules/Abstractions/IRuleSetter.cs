using SolidSample.Enums;
using SolidSample.Models;

namespace SolidSample.Game.GameRules.RulesDefinitions.Rules
{
    public interface IRuleSetter
    {
        /// <summary>
        /// Действия, которые необходимо выполнить в данном правиле
        /// </summary>
        /// <param name="gameState"></param>
        /// <returns></returns>
        Task GetExecutableFunction(ActualGameState gameState);

        /// <summary>
        /// Условия, при которых данных данное правило должно быть выполнено
        /// </summary>
        /// <param name="gameState"></param>
        /// <returns></returns>
        bool GetValidationFunction(ActualGameState gameState);

        /// <summary>
        /// Приоритет операции
        /// </summary>
        GameRulePriority Priority { get; }
    }
}
