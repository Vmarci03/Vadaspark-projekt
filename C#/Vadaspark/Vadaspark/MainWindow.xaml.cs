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
using System.IO;

namespace Vadaspark
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void closeapp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void datawritedown_Click(object sender, RoutedEventArgs e)
        {

            StreamWriter sw = new StreamWriter("nyilvantartas.txt",true);

            sw.WriteLine("Állat neve: {0}\nÁllat fajtája: {1}\nSzületési idő:{2}\nNőstény: {3}/Hím: {4}");

            sw.Flush();
            sw.Close();

        }
    }
}
