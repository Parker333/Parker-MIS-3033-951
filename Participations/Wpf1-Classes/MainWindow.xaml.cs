using DocumentFormat.OpenXml.Wordprocessing;
using Nest;
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

namespace Wpf1_Classes
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Info myinfo = new Info()
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                Zipcode = Convert.ToInt32(txtZipcode)
            };

            lstInfo.Items.Add(myinfo);
            txtName.Clear();
            txtAddress.Clear();
            txtZipcode.Clear();
        }

        private void lstInfo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
