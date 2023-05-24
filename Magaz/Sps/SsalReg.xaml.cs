using Magaz.Model;
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
    /// Логика взаимодействия для SsalReg.xaml
    /// </summary>
    public partial class SsalReg : Page
    {
        public SsalReg()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SsalGrid.ItemsSource = AppData.db.Ssal.ToList();
        }
    }
}
