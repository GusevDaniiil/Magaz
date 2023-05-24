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
    /// Логика взаимодействия для PoslPage.xaml
    /// </summary>
    public partial class PoslPage : Page
    {
        public PoslPage()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Users people = new Users();

            people.Login = textBoxLogin.Text;
            people.Password = textBoxPassword.Text;
            people.Email = textBoxEmail.Text;

            AppData.db.Users.Add(people);
            AppData.db.SaveChanges();
            MessageBox.Show("Пользователь добавлен в базу");
            NavigationService.GoBack();

        }
    }
}
