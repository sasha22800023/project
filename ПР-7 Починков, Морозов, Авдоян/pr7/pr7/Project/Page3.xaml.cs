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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            DGridpage3.ItemsSource = OdbConnectHelper.entObj.Компьютер.ToList();
        }

        private void DGridpage3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            {
                try
                {

                    Компьютер empObj = new Компьютер()
                    {
                        IP_адрес = txbip.Text,
                        Кабинет = txboffice.Text,
                        Характеристики = txbCharacteristic.Text,

                    };
                    OdbConnectHelper.entObj.Компьютер.Add(empObj);
                    OdbConnectHelper.entObj.SaveChanges();
                    MessageBox.Show("ПК " + empObj.Номер_компьютера + " уcпешно добавлен!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошли технические неполадки: " + ex.Message.ToString(), "Кртический сбой работы", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DGridpage3.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < DGridpage3.SelectedItems.Count; i++)
                    {
                        Компьютер quiObj = DGridpage3.SelectedItems[i] as Компьютер;
                        OdbConnectHelper.entObj.Компьютер.Remove(quiObj);
                    }
                    OdbConnectHelper.entObj.SaveChanges();
                    MessageBox.Show("Данные удалены", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
                    DGridpage3.ItemsSource = OdbConnectHelper.entObj.Компьютер.ToList();
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
    }
}
