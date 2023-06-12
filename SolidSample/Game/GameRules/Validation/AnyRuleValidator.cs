using SolidSample.Game.GameRules.OneRule;
using SolidSample.Models;

namespace SolidSample.Game.GameRules.Validation
{
    /// <summary>
    /// Реализация валидатора, проверяющая, что правила существуют при любых игровых ситуациях
    /// </summary>
    internal class AnyRuleValidator : IRulesValidator
    {
        private Settings Settings { get; }

        public AnyRuleValidator(Settings settings)
        {
            Settings = settings;
        }

        public bool Validate(IEnumerable<IGameRule> rules)
        {
            var gameState = new ActualGameState();
            gameState.TryCount = 0;
            for (int i = Settings.Range.MinValue; i <= Settings.Range.MaxValue; i++)
            {
                gameState.PlayerNumber = i;
                for (int j = Settings.Range.MinValue; j <= Settings.Range.MaxValue; j++) 
                {
                    gameState.ComputerNumber = j;
                    var simulation = rules.Where(rule => rule.IsValid(gameState));
                    if (gameState.TryCount > 0)
                    {
                        gameState.TryCount = 0;
                    }

                    if (simulation.Any())
                    {
                        continue;
                    }

                    throw new Exception($"При значениях Игрок: {i}, Компьютер: {j} не найдено ни одного игрового правила");
                }
                
            }

            return true;
        }
    }
}
