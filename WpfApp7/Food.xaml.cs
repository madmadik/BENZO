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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для Food.xaml
    /// </summary>
    public partial class Food : Page
    {
        public Food()
        {
            InitializeComponent();
        }
        public Double Price { get; set; } = 0;

        public void AddPrice(string text)
        {
            Price += double.Parse(text);
        }

        private void Button_Order(object sender, RoutedEventArgs e)
        {
            Prices prices = new Prices();
            Price += double.Parse(MealCount.Text) * prices.Meal + double.Parse(DrinkCount.Text) * prices.Drink;
            MainWindow page = new MainWindow();
            page.price.Text = Price.ToString();
            page.Show();
        }
    }
}
