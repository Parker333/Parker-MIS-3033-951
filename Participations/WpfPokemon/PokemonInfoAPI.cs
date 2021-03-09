using System;
using System.Collections.Generic;
using System.Text;

namespace WpfPokemon
{
    public class PokemonInfoAPI
    {
        public double height { get; set; }
        public Sprite sprites { get; set; }
        public double weight { get; set; }
    }

    public class Sprite
    {
        public string back_default { get; set; }
        public string front_default { get; set; }
    }
}
