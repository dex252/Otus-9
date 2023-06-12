using SolidSample.Enums;
using SolidSample.Models;

namespace SolidSample.Game.GameRules.RulesDefinitions.Rules
{
    internal class FinishGameRule : IRuleSetter
    {
        Settings Settings { get; }
        public GameRulePriority Priority => GameRulePriority.High;
        public FinishGameRule(Settings settings)
        {
            Settings = settings;
        }

        public async Task GetExecutableFunction(ActualGameState actualGameState)
        {
            actualGameState.State = GameState.FINISH;
            await Console.Out.WriteLineAsync("Наши поздравления, вы отгадали число и одержали победу!");
        }

        public bool GetValidationFunction(ActualGameState actualGameState)
        {
            return actualGameState.ComputerNumber == actualGameState.PlayerNumber;
        }
    }
}
