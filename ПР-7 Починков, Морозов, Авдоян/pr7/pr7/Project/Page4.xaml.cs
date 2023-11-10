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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
            txbpragrom.SelectedValuePath = "Код_программы";
            txbpragrom.DisplayMemberPath = "Название";
            txbpragrom.ItemsSource = OdbConnectHelper.entObj.Программа.ToList();
            DGridpage3.ItemsSource = OdbConnectHelper.entObj.Программа.ToList();

            txbpc.SelectedValuePath = "Номер_компьютера";
            txbpc.DisplayMemberPath = "IP_адрес";
            txbpc.ItemsSource = OdbConnectHelper.entObj.Компьютер.ToList();
            DGridpage3.ItemsSource = OdbConnectHelper.entObj.Компьютер.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            {
                {
                    try
                    {

                        Установка empObj = new Установка()
                        {
                            Программа = txbpragrom.SelectedItem as Программа,
                            Компьютер = txbpc.SelectedItem as Компьютер,
                            Дата_установки = txbdate.Text,
                            Режим_установки = txbreg.Text,

                        };
                        OdbConnectHelper.entObj.Установка.Add(empObj);
                        OdbConnectHelper.entObj.SaveChanges();
                        MessageBox.Show("Установлено " + empObj.Номер_компьютера + " программ", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошли технические неполадки: " + ex.Message.ToString(), "Кртический сбой работы", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    if (DGridpage3.SelectedItems.Count > 0)
                    {
                        for (int i = 0; i < DGridpage3.SelectedItems.Count; i++)
                        {
                            Установка empObj = DGridpage3.SelectedItems[i] as Установка;
                            OdbConnectHelper.entObj.Установка.Remove(empObj);
                        }
                        OdbConnectHelper.entObj.SaveChanges();
                        MessageBox.Show("Данные удалены", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
                        DGridpage3.ItemsSource = OdbConnectHelper.entObj.Установка.ToList();
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
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DGridpage3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
