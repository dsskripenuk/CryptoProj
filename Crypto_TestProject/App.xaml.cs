using Crypto_TestProject.Data;
using System.Windows;

namespace Crypto_TestProject
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            CoinGecko.UpDateList();
        }
    }
}
