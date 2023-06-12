using SolidSample.Game.GameRules.OneRule;

namespace SolidSample.Game.GameRules.Validation
{
    internal interface IRulesValidator
    {
        /// <summary>
        /// Проверить правила игры на наличие ошибок
        /// </summary>
        /// <returns></returns>
        bool Validate(IEnumerable<IGameRule> rules);
    }
}
