using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Сахар",
                Price = 100,
                Image = 1,
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Самолетик",
                Price = 350,
                Image = 2,
                ProductType = ProductTypes.Toy
            });
            products.Add(new Product()
            {
                ProductName = "Телефон",
                Price = 1500,
                Image = 3,
                ProductType = ProductTypes.Electronics
            });
            listBox.ItemsSource = products;
        }
    }
}
