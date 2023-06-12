using SolidSample.Game.GameRules.OneRule;
using SolidSample.Models;

namespace SolidSample.Game.GameRules.Validation
{
    /// <summary>
    /// Реализация валидатора, проверяющая, что все правила могут быть получены в единственном экземпляре
    /// </summary>
    internal class SingleRuleValidator : IRulesValidator
    {
        private Settings Settings { get; }

        public SingleRuleValidator(Settings settings)
        {
            Settings = settings;
        }

        public bool Validate(IEnumerable<IGameRule> rules)
        {
            throw new NotImplementedException();
        }
    }
}
