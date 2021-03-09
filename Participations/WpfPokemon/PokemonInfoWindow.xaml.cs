using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfPokemon
{
    /// <summary>
    /// Interaction logic for PokemonInfoWindow.xaml
    /// </summary>
    public partial class PokemonInfoWindow : Window
    {
        public PokemonInfoWindow()
        {
            InitializeComponent();
        }

        internal void PopulateWindow(PokemonInfoAPI info)
        {
            imgPokemon.Source = new BitmapImage(new Uri(info.sprites.front_default));
        }
    }
}
