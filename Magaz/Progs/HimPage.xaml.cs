﻿using Magaz.Sps;
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

namespace Magaz.Progs
{
    /// <summary>
    /// Логика взаимодействия для HimPage.xaml
    /// </summary>
    public partial class HimPage : Page
    {
        public HimPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ScusReg());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SsalReg());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
