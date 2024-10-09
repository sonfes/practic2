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

namespace WP_T_F_first
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, RoutedEventArgs e)
        {
            String title = (string)((Button)e.OriginalSource).Content;
            if (title == "Click Me")
            {
                Random rnd = new Random();
                runner.Margin = new Thickness(rnd.Next(-750,750), rnd.Next(-350,350), 0, 0);
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }
    }
}