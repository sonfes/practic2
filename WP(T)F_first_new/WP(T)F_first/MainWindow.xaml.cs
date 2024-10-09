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

namespace WP_T_F_first
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String title = (string)((Button)e.OriginalSource).Content;
            if (title  == "Do Not Press")
            {
                Window1 window1 = new Window1();
                window1.Show();
                this.Close();
            }
            else if (title == "Taffic Light")
            {
                Window2 window2 = new Window2();
                window2.Show();
                this.Close();
            }
            else
            {
                Window3 window3 = new Window3();
                window3.Show();
                this.Close();
            }
        }
    }
}
