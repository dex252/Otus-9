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

        public void FillRules(IEnumerable<IGameRule> rules)
        {
            var rulesSetters = RulesBuilder.GetRules();
            foreach (var rulesSetter in rulesSetters)
            {
                rules.Append(new GameRule(rulesSetter.GetExecutableFunction, rulesSetter.GetValidationFunction, rulesSetter.Priority));
            }
        }
    }
}
