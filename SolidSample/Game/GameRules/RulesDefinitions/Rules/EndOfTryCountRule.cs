using SolidSample.Enums;
using SolidSample.Game.GameRules.RulesDefinitions.Rules.Abstractions;
using SolidSample.Models;

namespace SolidSample.Game.GameRules.RulesDefinitions.Rules
{
    internal class EndOfTryCountRule : IRuleSetter
    {
        Settings Settings { get; }

        public GameRulePriority Priority => GameRulePriority.High;

        public EndOfTryCountRule(Settings settings)
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
