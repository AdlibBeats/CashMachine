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
using CashMachine.SQL;
using System.Collections.ObjectModel;
using CashMachine.Model;
using System.Threading;
using System.Windows.Threading;

namespace CashMachine
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        public Task GetProducts()
        {
            Task task = Task.Factory.StartNew(() =>
            {
                Connection con = new Connection();
                Products = con.GetProducts();
                this.Dispatcher.BeginInvoke(DispatcherPriority.Background, (ThreadStart)delegate ()
                {
                    this.DataContext = this;
                });
            });
            return task;
        }

        async void Button_Click(object sender, RoutedEventArgs e)
        {
            await GetProducts();
        }
    }
}
