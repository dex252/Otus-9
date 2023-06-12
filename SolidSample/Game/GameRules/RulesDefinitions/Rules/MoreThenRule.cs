using SolidSample.Enums;
using SolidSample.Game.GameRules.RulesDefinitions.Rules.Abstractions;
using SolidSample.Models;

namespace SolidSample.Game.GameRules.RulesDefinitions.Rules
{
    internal class MoreThenRule : BaseInput, IRuleSetter
    {
        Settings Settings { get; }
        public GameRulePriority Priority => GameRulePriority.Low;

        public MoreThenRule(Settings settings)
        {
            Settings = settings;
        }

        public async Task GetExecutableFunction(ActualGameState actualGameState)
        {
            actualGameState.State = GameState.PROCESS;
            actualGameState.TryCount++;
            await Console.Out.WriteLineAsync($"Загаданное число меньше, чем ввел игрок. Осталось попыток: {Settings.MaxTryCount - actualGameState.TryCount}");

            var number = await GetInputByPlayer();
            actualGameState.PlayerNumber = number;
        }

        public bool GetValidationFunction(ActualGameState actualGameState)
        {
            return actualGameState.PlayerNumber > actualGameState.ComputerNumber;
        }
    }
}
