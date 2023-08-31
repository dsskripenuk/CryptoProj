using Crypto_TestProject.Model;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using Crypto_TestProject.Data;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows;
using System.Linq;
using Crypto_TestProject.View;
using Crypto_TestProject.Data.Gecko;
using Crypto_TestProject.Data.GeckoTop;

namespace Crypto_TestProject.ViewModel
{
    class CryptoCurrencyViewModel : INotifyPropertyChanged
    {
        private List<CoinFormat> items;
        private List<CoinTopFormat> itemsTop;
        public List<CoinFormat> ItemsSource
        {
            get => items;
            set
            {
                items = value;
                OnPropertyChanged(nameof(ItemsSource));
            }
        }

        public List<CoinTopFormat> ItemsSourceTop
        {
            get => itemsTop;
            set
            {
                itemsTop = value;
                OnPropertyChanged(nameof(ItemsSourceTop));
            }
        }

        private string cmc_rank;
        public string Cmc_rank
        {
            get => cmc_rank;
            set
            {
                cmc_rank = value;
                OnPropertyChanged(nameof(Cmc_rank));
            }
        }
        private string imageSource;
        public string ImageSource
        {
            get => imageSource;
            set
            {
                imageSource = value;
                OnPropertyChanged(nameof(ImageSource));
            }
        }
        

        public CryptoCurrencyViewModel()
        {
            CryptoCurrencyModel model = new CryptoCurrencyModel();
            ItemsSource = new List<CoinFormat>();
            ItemsSourceTop = new List<CoinTopFormat>();
            ItemsSource.AddRange(GetFormat(model.ItemsSource));
            ItemsSourceTop.AddRange(GetFormatTop(model.topItemSource));
        }

        public List<CoinTopFormat> GetFormatTop(List<CoinTop> coins)
        {
            var result = new List<CoinTopFormat>();
            foreach (var item in coins)
            {
                var formatCoin = new CoinTopFormat(item);
                result.Add(formatCoin);
            }
            return result;
        }
        public List<CoinFormat> GetFormat(List<Coin> coins)
        {
            var result = new List<CoinFormat>();
            foreach(var item in coins)
            {
                var formatCoin = new CoinFormat(item);
                result.Add(formatCoin);
            }
            return result;
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