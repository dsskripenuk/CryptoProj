using Crypto_TestProject.Data.Gecko;
using Crypto_TestProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Crypto_TestProject.View
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : UserControl
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, MouseButtonEventArgs e)
        {
            CoinFormat coin = new CoinFormat();
            CryptoCurrencyViewModel item = new CryptoCurrencyViewModel();

            foreach (var item1 in item.ItemsSource)
            {
                if (item1.Name == coin_text.Text)
                {
                    textblock_name.Text = item1.Name; 
                }
            }


        }

    }
}
