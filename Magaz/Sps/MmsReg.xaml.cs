﻿using Magaz.Dob;
using Magaz.Model;
using Magaz.Progs;
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

namespace Magaz.Sps
{
    /// <summary>
    /// Логика взаимодействия для MmsReg.xaml
    /// </summary>
    public partial class MmsReg : Page
    {
        public MmsReg()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MmsGrid.ItemsSource = AppData.db.Mmas.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MmsPage());
        }
    }
}
