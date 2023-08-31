using Crypto_TestProject.Data.Gecko;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Crypto_TestProject.Data.GeckoTop
{
    internal class CoinTopFormat
    {
        public string Id { get; set; }
        public string Coin_id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Market_cap_rank { get; set; }
        public string Image { get; set; }
        public string Small { get; set; }
        public string Large { get; set; }
        public string Slug { get; set; }
        public string Price { get; set; }
        public string Score { get; set; }
       
        public CoinTopFormat(CoinTop coin)
        {
            Id = coin.id;
            Coin_id = coin.coin_id;
            Name = coin.name.ToString();
            Symbol = coin.symbol.ToString().ToUpper();
            Market_cap_rank = coin.market_cap_rank.ToString();
            Image = coin.image.ToString();
            Small = coin.small.ToString();
            Large = coin.large.ToString();
            Slug = coin.slug.ToString();
            Price = coin.price_btc.ToString();
            Score = coin.score.ToString();
        }
    }
}
