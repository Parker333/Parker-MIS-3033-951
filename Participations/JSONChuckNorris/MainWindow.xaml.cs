using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JSONChuckNorris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtChuckNorrisJoke.IsEnabled = false;

            string[] chuck; ;

            using (var client = new HttpClient())
            {
                string jsonResults = client.GetStringAsync(@"https://api.chucknorris.io/jokes/categories").Result;

                chuck = JsonConvert.DeserializeObject<string[]>(jsonResults);
            }

            cboCategory.Items.Add("All");

            foreach (var item in chuck)
            {
                cboCategory.Items.Add(item);
            }
        }

        private void cboCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedcategory = cboCategory.SelectedItem;

        }

        private void btnJoke_Click(object sender, RoutedEventArgs e)
        {
            txtChuckNorrisJoke.IsEnabled = true;
            //ChuckNorrisAPI();
            
            //I'm very lost and will be coming in for office hours
        }
    }
}
