using pr7.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void program_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Page2());
        }

        private void Computer_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Page3());
        }

        private void Installation_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Page4());
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new login());
        }
    }
}
