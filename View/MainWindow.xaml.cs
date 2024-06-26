﻿using PoopyClicker.Model;
using PoopyClicker.View;
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

namespace PoopyClicker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Upgrades upg = new Upgrades();
            upg.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Gallery titri = new Gallery();
            titri.Show();
            Close();
        }
    }
}
