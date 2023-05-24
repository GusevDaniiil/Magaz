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

namespace Magaz.Dob
{
    /// <summary>
    /// Логика взаимодействия для MmsPage.xaml
    /// </summary>
    public partial class MmsPage : Page
    {
        public MmsPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mmas people = new Mmas();

            people.Name_Brend = textBoxBrend.Text;
            people.Viscosity = textBoxViscosity.Text;
            people.Country = textBoxCountry.Text;
            people.Price = textBoxPrice.Text;

            AppData.db.Mmas.Add(people);
            AppData.db.SaveChanges();
            MessageBox.Show("Запись добавлена");
            NavigationService.GoBack();
        }
    }
}
