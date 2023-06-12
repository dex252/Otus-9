using Newtonsoft.Json;

namespace SolidSample.Models
{
    internal class Settings
    {
        /// <summary>
        /// Диапозон загаданного числа
        /// </summary>
        [JsonProperty("range")]
        public Range Range { get; set; }

        /// <summary>
        /// Число попыток отгадать число
        /// </summary>
        [JsonProperty("maxTryCount")]
        public int MaxTryCount { get; set; }
    }

    internal class Range
    {

        [JsonProperty("from")]
        public int MinValue { get; set; }

        [JsonProperty("to")]
        public int MaxValue { get; set; }
    }
}
