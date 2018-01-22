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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Oil(object sender,RoutedEventArgs e)
        {
            Oil page = new Oil();
            if (String.IsNullOrWhiteSpace(price.Text))
            {
                this.Content = page;
            }
            else
            {
                page.AddPrice(this.price.Text);
                this.Content = page;
            }
        }
        private void Button_Food(object sender,RoutedEventArgs e)
        {

            Food page = new Food();
            if (String.IsNullOrWhiteSpace(price.Text))
            {
                this.Content = page;
            }
            else
            {
                page.AddPrice(price.Text);
                this.Content=page;
            }
        }  
    }
}
