using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_TestProject.Data.GeckoTop
{
    internal class CoinTop
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("coin_id")]
        public string coin_id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("symbol")]
        public string symbol { get; set; }

        [JsonProperty("market_cap_rank")]
        public int market_cap_rank { get; set; }

        [JsonProperty("thumb")]
        public string image { get; set; }

        [JsonProperty("small")]
        public string small { get; set; }

        [JsonProperty("large")]
        public string large { get; set; }

        [JsonProperty("slug")]
        public string slug { get; set; }

        [JsonProperty("price_btc")]
        public double price_btc { get; set; }

        [JsonProperty("score")]
        public int score { get; set; }




        
    }
}
