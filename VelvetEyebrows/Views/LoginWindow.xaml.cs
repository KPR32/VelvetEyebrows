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
using VelvetEyebrows.Views;

namespace VelvetEyebrows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();


        }

        private void login(object sender, RoutedEventArgs e)
        {
            var wnd = (isKioskCheckBox.IsChecked, pinCodeInput.Password) switch
            {
                (false, "0000") => new MainWindow(true),
                (true, _) => new MainWindow(false),
                _ => null
            };
            if (wnd is null)
            {
                MessageBox.Show("Не верный PIN!", "Вход не выполнен", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            wnd.Show();
            Close();
        }
    }
}
