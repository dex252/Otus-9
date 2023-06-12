using SolidSample.Enums;
using SolidSample.Game.GameRules.RulesDefinitions.Rules.Abstractions;
using SolidSample.Models;

namespace SolidSample.Game.GameRules.RulesDefinitions.Rules
{
    internal class WrongNumberGameRule : BaseInput, IRuleSetter
    {
        Settings Settings { get; }
        public GameRulePriority Priority => GameRulePriority.Low;

        public WrongNumberGameRule(Settings settings)
        {
            Settings = settings;
        }

        public async Task GetExecutableFunction(ActualGameState actualGameState)
        {
            actualGameState.TryCount++;
            actualGameState.State = GameState.PROCESS;
            await Console.Out.WriteLineAsync($"Не верно. Загаданное число находится в диапозоне от {Settings.Range.MinValue} до {Settings.Range.MaxValue}");
            await Console.Out.WriteLineAsync($"Введите число:");

            var number = await GetInputByPlayer();
            actualGameState.PlayerNumber = number;
        }

        public bool GetValidationFunction(ActualGameState actualGameState)
        {
            return actualGameState.PlayerNumber > Settings.Range.MaxValue ||
                   actualGameState.PlayerNumber < Settings.Range.MinValue;
        }
    }
}
