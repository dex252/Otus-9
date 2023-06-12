using SolidSample.Game.Builders;
using SolidSample.Game.GameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.Game
{
    internal class GameRunner
    {
        const int DELAY_TIME_MS = 200;

        IGameBuilder GameBuilder { get; }
        IGameProcess GameProcess { get; }

        public GameRunner(IGameBuilder gameBuilder)
        {
            GameBuilder = gameBuilder;
            GameProcess = new GameProcess(GameBuilder);
        }

        internal async Task Run()
        {
            while (GameProcess.IsFinishGame())
            {
                await Task.Delay(DELAY_TIME_MS);
                await GameProcess.NextAction();
            }
        }
    }
}
