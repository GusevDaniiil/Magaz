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
    /// Логика взаимодействия для VidReg.xaml
    /// </summary>
    public partial class VidReg : Page
    {
        public VidReg()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            VidGrid.ItemsSource = AppData.db.Navig.ToList();
        }
    }
}
