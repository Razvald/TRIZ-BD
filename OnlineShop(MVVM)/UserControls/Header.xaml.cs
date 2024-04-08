using OnlineShop_MVVM_.Views;
using System.Windows;
using System.Windows.Controls;

namespace OnlineShop_MVVM_.UserControls
{
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginWind loginWind = new();
            loginWind.Show();
        }

        private void btnData_Click(object sender, RoutedEventArgs e)
        {
            PickupEmployeeWind pickupEmployeeWind = new();
            pickupEmployeeWind.Show();
        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            ProductsWind productsWind = new();
            productsWind.Show();
        }

        private void btnStatistic_Click(object sender, RoutedEventArgs e)
        {
            StatisticsWind statisticsWind = new();
            statisticsWind.Show();
        }
    }
}
