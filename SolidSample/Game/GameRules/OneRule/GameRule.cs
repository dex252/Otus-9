using SolidSample.Enums;
using SolidSample.Models;

namespace SolidSample.Game.GameRules.OneRule
{
    public class GameRule : IGameRule
    {
        Func<ActualGameState, Task> ExecuteFunction { get; }
        Func<ActualGameState, bool> ValidateFunction { get; }
        GameRulePriority Priority { get; }

        public GameRule( 
            Func<ActualGameState, Task> executeFunction, 
            Func<ActualGameState, bool> validateFunction,
            GameRulePriority priority)
        {
            ExecuteFunction = executeFunction;
            ValidateFunction = validateFunction;
            Priority = priority;
        }

        public Task Execute(ActualGameState gameState)
        {
            return ExecuteFunction.Invoke(gameState);
        }

        public bool IsValid(ActualGameState gameState)
        {
            return ValidateFunction.Invoke(gameState);
        }

        public bool IsHightPriority()
        {
            return Priority == GameRulePriority.High;
        }
    }
}
