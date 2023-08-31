using Newtonsoft.Json;

namespace Crypto_TestProject.Data
{
    public class Quote
    {
        [JsonProperty("USD")]
        public USD usd { get; set; }
    }
}
