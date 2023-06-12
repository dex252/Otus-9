using SolidSample.Enums;
using SolidSample.Game.GameRules.RulesDefinitions.Rules.Abstractions;
using SolidSample.Models;

namespace SolidSample.Game.GameRules.RulesDefinitions.Rules
{
    internal class StartGameRule: BaseInput, IRuleSetter
    {
        Settings Settings { get; }

        public GameRulePriority Priority => GameRulePriority.High;

        public StartGameRule(Settings settings)
        {
            Settings = settings;

        }

        public async Task GetExecutableFunction(ActualGameState actualGameState)
        {
            actualGameState.State = GameState.PROCESS;
            await Console.Out.WriteLineAsync($"Игра началась! Компьютер загадал число в диапозоне от {Settings.Range.MinValue} до {Settings.Range.MaxValue}.");

            var number = await GetInputByPlayer();
            actualGameState.PlayerNumber = number;
        }

        public bool GetValidationFunction(ActualGameState actualGameState)
        {
            return actualGameState.State == GameState.START;
        }
    }
}
