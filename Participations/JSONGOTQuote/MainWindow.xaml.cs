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

namespace JSONGOTQuote
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

        private void btnQuote_Click(object sender, RoutedEventArgs e)
        {
            GOTAPI api;
            string url = "https://got-quotes.herokuapp.com/quotes";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<GOTAPI>(json);
            }

        }

        private void txtQuote_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Again I'm very lost and will be coming into office hours! I'm gennuinely trying though!
        }
    }
}
