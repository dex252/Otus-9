using SolidSample.Models;

namespace SolidSample.Game.Builders
{
    internal class RandomNumberGenerator : INumberGenerator
    {
        Settings Settings { get; }

        public RandomNumberGenerator(Settings settings)
        {
            Settings = settings;
        }

        public int GenerateNumber()
        {
            var rnd = new Random();
            return rnd.Next(Settings.Range.MinValue, Settings.Range.MaxValue);
        }
    }
}
