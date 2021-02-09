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

namespace Wpf_Participation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtName.Clear();
        }

        private void btnStart_Click_1(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Blue;

            MessageBox.Show("Please enter your information", "Clicked", MessageBoxButton.OKCancel);

            string birthday = txtBirthday.Text;
            DateTime result = Convert.ToDateTime(birthday);
            DateTime now = DateTime.Now;
            TimeSpan age = now - result;

            MessageBox.Show ($"{txtName} is {age.TotalDays/365}.");
            lblOutput.Content = ($"{txtName} is {age.TotalDays/365}.");
        }
    }
}
