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

namespace Magaz.Progs
{
    /// <summary>
    /// Логика взаимодействия для GlavPage.xaml
    /// </summary>
    public partial class GlavPage : Page
    {
        public GlavPage()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUsers = AppData.db.Users.FirstOrDefault(u => u.Login == textBoxLogin.Text && u.Email == textBoxEmail.Text);
            if (CurrentUsers != null)
            {
                NavigationService.Navigate(new NextPage());
            }else
            {
                MessageBox.Show("Данного пользователя нет в базе");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PoslPage());
        }
    }
}
