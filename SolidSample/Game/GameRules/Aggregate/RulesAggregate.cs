using SolidSample.Game.GameRules.OneRule;

namespace SolidSample.Game.GameRules.Aggregate
{
    internal class RulesAggregate : IRulesAggregate
    {
        IRulesBuilder RulesBuilder { get; }

        public RulesAggregate(IRulesBuilder rulesBuilder)
        {
            RulesBuilder = rulesBuilder;
        }

        public IEnumerable<IGameRule> FillRules()
        {
            var rules = new List<IGameRule>();
            var rulesSetters = RulesBuilder.GetRules();
            foreach (var rulesSetter in rulesSetters)
            {
                 rules.Add(new GameRule(rulesSetter.GetExecutableFunction, rulesSetter.GetValidationFunction, rulesSetter.Priority));
            }

            return rules;
        }
    }
}
