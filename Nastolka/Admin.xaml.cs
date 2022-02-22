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
using System.Windows.Shapes;

namespace Nastolka
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mam = new MainWindow();
            mam.Show();
            Close();
        }

        private void GrafikKyrsov_Click(object sender, RoutedEventArgs e)
        {
            NashaRamka.Navigate(new Pages.Grafiki());
        }

        private void Xranish_Click(object sender, RoutedEventArgs e)
        {
            NashaRamka.Navigate(new Pages.Hranilishe());
        }

        private void Otchetik_Click(object sender, RoutedEventArgs e)
        {
            NashaRamka.Navigate(new Pages.Otchet());
        }

        private void Formirovanie_Click(object sender, RoutedEventArgs e)
        {
            NashaRamka.Navigate(new Pages.Formirovanie());
        }
    }
}
