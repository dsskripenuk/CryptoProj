using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Crypto_TestProject.Data;
using Crypto_TestProject.Data.Gecko;
using Crypto_TestProject.Data.GeckoTop;
using Newtonsoft.Json;

namespace Crypto_TestProject.Model
{
    class CryptoCurrencyModel : INotifyPropertyChanged
    {
        //private string API_KEY = "025df3bc-79d6-45d3-83c3-76594a50f8d4";
        private List<Coin> items;
        private List<CoinTop> topItems;

        public List<CoinTop> topItemSource
        {
            get => topItems;
            set
            {
                topItems = value;
                OnPropertyChanged(nameof(topItems));
            }
        }
        public List<Coin> ItemsSource
        {
            get => items;
            set
            {
                items = value;
                OnPropertyChanged(nameof(ItemsSource));
            }
        }

        public CryptoCurrencyModel()
        {
            ItemsSource = new List<Coin>();
            topItemSource = new List<CoinTop>();

            ItemsSource.AddRange(CoinGecko.Coins);
            //topItemSource.AddRange(CoinGecko.coinTops);
        }
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
