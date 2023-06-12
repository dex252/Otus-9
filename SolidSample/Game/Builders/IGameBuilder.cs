using SolidSample.Game.GameRules.RulesBundle;
using SolidSample.Models;

namespace SolidSample.Game.Builders
{
    internal interface IGameBuilder
    {
        /// <summary>
        /// Построить правила игры
        /// </summary>
        IGamesRules Build();
    }
}
