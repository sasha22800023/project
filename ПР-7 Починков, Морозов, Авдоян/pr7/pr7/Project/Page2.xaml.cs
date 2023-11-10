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
using System.Xml.Linq;

namespace pr7.Project
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            DGridpage2.ItemsSource = OdbConnectHelper.entObj.Программа.ToList();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DGridpage2.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < DGridpage2.SelectedItems.Count; i++)
                    {
                        Программа empObj = DGridpage2.SelectedItems[i] as Программа;
                        OdbConnectHelper.entObj.Программа.Remove(empObj);
                    }
                    OdbConnectHelper.entObj.SaveChanges();
                    MessageBox.Show("Данные удалены", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
                    DGridpage2.ItemsSource = OdbConnectHelper.entObj.Программа.ToList();
                }
                else
                {
                    MessageBox.Show("Таких данных в таблице нет!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошли технические неполадки: " + ex.Message.ToString(), "Кртический сбой работы", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            {
                try
                {

                    Программа empObj = new Программа()
                    {
                        Название = txbNames.Text,
                        Версия = txbVersion.Text,
                        Класс = txbClass.Text,
                        Объем = txbVolume.Text,

                    };
                    OdbConnectHelper.entObj.Программа.Add(empObj);
                    OdbConnectHelper.entObj.SaveChanges();
                    MessageBox.Show("Установлено " + empObj.Название + " программ", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошли технические неполадки: " + ex.Message.ToString(), "Кртический сбой работы", MessageBoxButton.OK, MessageBoxImage.Warning);

                }
            }
        }

        private void DGridpage2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
