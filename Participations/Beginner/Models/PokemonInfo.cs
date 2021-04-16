using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beginner.Models
{
    public class PokemonInfo
    {
        public string name { get; set; }
        public string id { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public Sprites sprites { get; set; }
    }
    public class Sprites
    {
        public string back_default { get; set; }
        public string front_default { get; set; }

    }
}