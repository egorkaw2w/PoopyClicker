using PoopyClicker.Model;
using PoopyClicker.ViewModel;
using PoopyClicker.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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

namespace PoopyClicker.View
{
    /// <summary>
    /// Логика взаимодействия для Upgrades.xaml
    /// </summary>
    public partial class Upgrades : Window
    {
        public Upgrades()
        {
            InitializeComponent();
            DataContext = new UpgradesViewModel();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }
    }
}
