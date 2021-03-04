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

namespace WpfPokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AllPokemonAPI api;
            string url = "https://pokeapi.co/api/v2/pokemon?limit=1200";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<AllPokemonAPI>(json); //Basically used as a split

            }

            foreach (var item in api.results.OrderBy(x => x.name).ToList())
            {
                lstPokemon.Items.Add(item);
            }
        }

        private void lstPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var selectedPokemon = (ResultObject)lstPokemon.SelectedItem;
            imgSprite.Source = new BitmapImage(new Uri(selectedPokemon.url));

            Info infomorepokemon;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(selectedPokemon.url).Result;

                infomorepokemon = JsonConvert.DeserializeObject<Info>(json); 

            } 

        }

        private void btnPokemon_Click(object sender, RoutedEventArgs e)
        {
            //I honestly can't figure this out.
        }
    }
}
