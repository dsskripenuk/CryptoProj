using Crypto_TestProject.Data;
using Crypto_TestProject.Data.Gecko;
using Crypto_TestProject.ViewModel;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Crypto_TestProject.View
{
    /// <summary>
    /// Логика взаимодействия для CryptoCurrencyView.xaml
    /// </summary>
    public partial class CryptoCurrencyView : UserControl
    {
        public CryptoCurrencyView()
        {
            InitializeComponent();
            DataContext = new CryptoCurrencyViewModel();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CoinFormat item = (CoinFormat)(sender as Grid).DataContext;
            name_grid.Text = item.Name.ToString();
            price_grid.Text = item.Current_price.ToString();
            mini_price_grid.Text = item.Price_change_24h.ToString();
            image.Source = new BitmapImage(new Uri(item.Image.ToString()));
            symbol_grid.Text = item.Symbol.ToString();
            market_cap_rank_grid.Text = item.Market_cap_rank.ToString();
            total_volume_grid.Text = item.Total_volume.ToString();
        }


        private void ListBoxItemPageViewCommand(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var grid = sender as Grid;
            var element = grid.DataContext as CoinFormat;
            var window = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
        }
    }
}
