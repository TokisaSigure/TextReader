using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;

namespace WpfApplication2
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {

        int pageNum = 0;
        int MAXNUM = 0;
        ArrayList al;

        public MainWindow()
        {
            InitializeComponent();
            YukariGames.TextLoadClass.LoadTexte(ref al);
            MAXNUM = al.Count;
            this.textBlock1.Text = (string)al[pageNum];
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (pageNum < MAXNUM-1)
                ++pageNum;
            this.textBlock1.Text = (string)al[pageNum];

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (pageNum > 0)
                --pageNum;
            this.textBlock1.Text = (string)al[pageNum];
        }
    }
}
