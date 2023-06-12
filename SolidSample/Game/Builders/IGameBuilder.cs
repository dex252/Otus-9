using SolidSample.Game.GameRules.RulesBundle;

namespace SolidSample.Game.Builders
{
    internal interface IGameBuilder
    {
        /// <summary>
        /// Построить правила игры
        /// </summary>
        IGamesRules Build();

        /// <summary>
        /// Сгенерировать число, загаданное компьютером
        /// </summary>
        /// <returns></returns>
        int GenerateComputerNumber();
    }
}
