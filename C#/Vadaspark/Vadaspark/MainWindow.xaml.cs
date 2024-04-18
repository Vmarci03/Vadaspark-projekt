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

            sw.WriteLine("Állat neve: {0}\nÁllat fajtája: {1}\nSzületési idő:{2}\nNőstény: {3}/Hím: {4}\nSzármazási hely: {5}\nVédett állat-e: igen: {6}/nem:{7}\nOsztály: Hüllők:{8}/Kétéltűek:{9}/Madarak:{10}/Emlősök:{11}\n\n", animalname.Text, animaltype.Text, birthday.Text, type_female.IsChecked, type_male.IsChecked, Place_of_origin.Text, yes_protected.IsChecked, not_protected.IsChecked, reptilian.IsChecked, amphibious.IsChecked, bird.IsChecked, mammals.IsChecked);

            sw.Flush();
            sw.Close();

            amount.Content = animallist.Items.Count;

            animalname.Text = "";
            animaltype.Text = "";
            birthday.Text = "";
            type_male.IsChecked = false;
            type_female.IsChecked = false;
            Place_of_origin.Text = "";
            yes_protected.IsChecked = false;
            not_protected.IsChecked = false;
            reptilian.IsChecked = false;
            amphibious.IsChecked = false;
            bird.IsChecked = false;
            mammals.IsChecked = false;
        }

        private void deletebtn_Click(object sender, RoutedEventArgs e)
        {
            if (animallist.SelectedIndex == -1)
            {

                MessageBox.Show("Nincs kijelölve egy halott állat sem!","Figyelmeztetés");

            }
            else
            {
                animallist.Items.RemoveAt(animallist.SelectedIndex);
            }
        }
    }
}
