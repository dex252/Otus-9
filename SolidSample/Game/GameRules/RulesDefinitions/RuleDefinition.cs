using SolidSample.Game.GameRules.Aggregate;
using SolidSample.Game.GameRules.OneRule;
using SolidSample.Game.GameRules.Validation;

namespace SolidSample.Game.GameRules.RulesDefinitions
{
    internal class RuleDefinition : IRuleDefinition
    {
        IRulesAggregate RulesAggregate { get; }
        IRulesValidator RulesValidator { get; }
        IEnumerable<IGameRule> Rules { get; }

        public RuleDefinition(IRulesAggregate rulesAggregate, IRulesValidator rulesValidator)
        {
            RulesValidator = rulesValidator;
            RulesAggregate = rulesAggregate;

            Rules = RulesAggregate.FillRules();
            RulesValidator.Validate(Rules);
        }

        public IEnumerable<IGameRule> GetRules()
        {
            foreach (var rule in Rules)
            {
                yield return rule;
            }
        }

    }
}
