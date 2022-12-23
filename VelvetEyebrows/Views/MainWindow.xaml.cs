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
using VelvetEyebrows.Models;

namespace VelvetEyebrows.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(bool isAdmin)
        {
            InitializeComponent();
            if (!isAdmin)
            {
                firstGridColumn.IsEnabled = false;
                firstGridColumn.Width = new GridLength(0);
                WindowStyle = WindowStyle.None;
                ResizeMode = ResizeMode.NoResize;
                WindowState = WindowState.Maximized;
                mainFrame.Navigate(new ServicesPage(false));

            }
        }

        private void navigateToServices(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ServicesPage(true));
        }

        private void navigateToUpcomingEntries(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new UpcomingEntriesPage());
        }
    }
}
