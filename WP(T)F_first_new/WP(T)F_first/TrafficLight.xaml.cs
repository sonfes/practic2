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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, RoutedEventArgs e)
        {
            String title = (string)((Button)e.OriginalSource).Content;
           
            if (title == "Red")
            { 
                cRed.Fill = Brushes.White;
                cYellow.Fill = Brushes.White;
                cGreen.Fill = Brushes.White;
            }
            else if (title == "Yellow")
            {
                cRed.Fill = Brushes.White;
                cYellow.Fill = Brushes.Yellow;
                cGreen.Fill = Brushes.White;
            }
            else if (title == "Green")
            {
                cRed.Fill = Brushes.White;
                cYellow.Fill = Brushes.White;
                cGreen.Fill = Brushes.Green;
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
