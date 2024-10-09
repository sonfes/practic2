﻿using System;
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

namespace practice_08_10
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        string word = "";

        Dictionary<string, string> TransWords = new Dictionary<string, string>()
        {
            { "метель", "snowstorm"},
            { "шторм", "storm"},
            { "солнце", "sun"},
            { "пасмурно", "cloudy"},
            { "ветер", "wind" },
            { "штиль", "calm" },
            { "дождь","rain" },
            { "гроза","tunder" },
            { "снег","snow" },
            { "туман","fog" },
        };
        


        private void GoBack(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            word = TextBoxOne.Text; 
        }

        private void translate(object sender, RoutedEventArgs e)
        {
            try
            {
                string trWord = word.ToLower();

                TrBox.Text = TransWords[trWord];
            }
            catch
            {
                TrBox.Text = "error, invalid value";
            }

        }
    }
}
