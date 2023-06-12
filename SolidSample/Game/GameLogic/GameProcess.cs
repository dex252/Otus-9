using SolidSample.Enums;
using SolidSample.Game.Builders;
using SolidSample.Game.GameRules.RulesBundle;
using SolidSample.Models;

namespace SolidSample.Game.GameLogic
{
    internal class GameProcess : IGameProcess
    {
        ActualGameState ActualGameState { get; }
        IGamesRules GameRules { get; }

        public GameProcess(IGameBuilder gameBuilder)
        {
            ActualGameState = new ActualGameState();
            ActualGameState.State = GameState.START;

            GameRules = gameBuilder.Build();
        }

        public async Task NextAction()
        {
            var rules = GameRules.GetRules(ActualGameState);
            foreach (var rule in rules)
            {
                await rule.Execute(ActualGameState);
            }
        }

        public bool IsFinishGame()
        {
            return ActualGameState.State == GameState.FINISH;
        }
    }
}
