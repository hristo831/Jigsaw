using Newtonsoft.Json;

namespace TestConfiguration
{
    /// <summary>
    /// Test Settings.
    /// </summary>
    public class TestSettings
    {
        /// <summary>
        /// Gets or sets Browser.
        /// </summary>
        [JsonProperty("Browser")]
        public string Browser { get; set; }

        /// <summary>
        /// Gets or sets Base url.
        /// </summary>
        [JsonProperty("BaseUrl")]
        public string BaseUrl { get; set; }
    }
}
