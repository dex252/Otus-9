using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidSample.Models;

namespace SolidSample.Game.GameRules.OneRule
{
    public class GameRule : IGameRule
    {
        private ActualGameState ActualGameState;

        public GameRule(ActualGameState actualGameState)
        {
            ActualGameState = actualGameState;
        }

        public Task Execute()
        {
            throw new NotImplementedException();
        }

        bool IGameRule.IsValid(ActualGameState gameState)
        {
            throw new NotImplementedException();
        }
    }
}
