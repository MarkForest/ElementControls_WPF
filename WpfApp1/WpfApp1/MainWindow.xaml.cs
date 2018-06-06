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

namespace WpfApp1
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

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Действие выполнено!");
        }

        private void escButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).IsChecked == true)
            {
                MessageBox.Show((sender as CheckBox).Content.ToString());
            }
            if((sender as CheckBox).IsChecked == null)
            {
                MessageBox.Show($"{(sender as CheckBox).Content.ToString()} Intermadiate");
            }
            if ((sender as CheckBox).IsChecked == false)
            {
                MessageBox.Show($"{(sender as CheckBox).Content.ToString()} and Fly");
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
       
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txb.Paste();
                    }

        private void btnCopy_Click(object sender, RoutedEventArgs e)
        {
            txb.Copy();
        }

        private void CheckBox_Click_1(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).IsChecked == true)
            {
                lbl.Visibility = Visibility;
            }
            else lbl.Visibility = Visibility.Hidden;
        }
    }
}
