using SolidSample.Game.GameRules.Aggregate;
using SolidSample.Game.GameRules.RulesBundle;
using SolidSample.Game.GameRules.RulesDefinitions;
using SolidSample.Game.GameRules.Validation;
using ConcretteGameRules = SolidSample.Game.GameRules.RulesBundle.GameRules;

namespace SolidSample.Game.Builders
{
    internal class GameBuilder : IGameBuilder
    {
        IRuleDefinition RuleDefinition { get; }

        public GameBuilder(IRulesAggregate rulesAggregate, IRulesValidator rulesValidator)
        {
            RuleDefinition = new RuleDefinition(rulesAggregate, rulesValidator);
        }

        public IGamesRules Build()
        {
            IGameRulesFillable gameRules = new ConcretteGameRules();
            var rules = RuleDefinition.GetRules();
            foreach (var rule in rules)
            {
                gameRules.AddRule(rule);
            }
            
            if (gameRules is IGamesRules)
            {
                return gameRules as IGamesRules;
            }

            throw new Exception("Не удалось привести игровые правила к базовому классу");
        }
    }
}
