using pr7.Class;
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

namespace pr7.Project
{
    /// <summary>
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
        }

        private void Login_in_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = OdbConnectHelper.entObj.Users.FirstOrDefault(
                    x => x.Login == Login.Text && x.Password == PasswordBox.Password);
                string login = Login.Text;
                string pass = PasswordBox.Password;

                if (userObj == null)
                {
                    MessageBox.Show("Не верный пароль!",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    PasswordBox.Background = Brushes.Red;
                }
                else
                {

                    FrameApp.frmObj.Navigate(new Page1());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критический сбор в работе приложения" + ex.Message.ToString(),
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void PasswordBox_LostFocus_1(object sender, RoutedEventArgs e)
        {

        }

        private void login_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void login_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void PasswordBox_GotFocus_1(object sender, RoutedEventArgs e)
        {

        }

        private void PasswordBox_LostFocus_2(object sender, RoutedEventArgs e)
        {

        }
    }
    }
