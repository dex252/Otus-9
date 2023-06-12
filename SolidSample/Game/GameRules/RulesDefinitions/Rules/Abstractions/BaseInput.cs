namespace SolidSample.Game.GameRules.RulesDefinitions.Rules.Abstractions
{
    abstract class BaseInput
    {
        public async Task<int> GetInputByPlayer()
        {
            var isValid = false;
            while (!isValid)
            {
                var input = await Console.In.ReadLineAsync();
                isValid = int.TryParse(input, out var value);
                if (!isValid)
                {
                    await Console.Out.WriteLineAsync($"Введенное значение не является числом! Повторите попытку.");
                    continue;
                }

                return value;
            }

            throw new NotImplementedException("Непредвиденное исключение при вводе с клавиатуры...");
        }
    }
}
