using SolidSample.Enums;
using SolidSample.Models;

namespace SolidSample.Game.GameRules.RulesDefinitions.Rules
{
    internal class EndOfTryCount : IRuleSetter
    {
        Settings Settings { get; }

        public GameRulePriority Priority => GameRulePriority.High;

        public EndOfTryCount(Settings settings)
        {
            Settings = settings;

        }

        public async Task GetExecutableFunction(ActualGameState actualGameState)
        {
            actualGameState.State = GameState.FINISH;
            await Console.Out.WriteLineAsync($"Количество попыток превышено, вы проиграли!");
        }

        public bool GetValidationFunction(ActualGameState actualGameState)
        {
            return actualGameState.TryCount >= Settings.MaxTryCount;
        }
    }
}
