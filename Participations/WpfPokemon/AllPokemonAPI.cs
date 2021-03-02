using System;
using System.Collections.Generic;
using System.Text;

namespace WpfPokemon
{
    public class AllPokemonAPI
    {
        public List<ResultObject> results { get; set; }
        public Info info { get; set; }

    }

    public class ResultObject
    {
        public string name { get; set; }
        public string url { get; set; }
        public string sprites { get; set; }

        public override string ToString()
        {
            return name;
        }

    }

    public class Info
    {
        public int height { get; set; }
        public int weight { get; set; }
        public string sprites { get; set; }
    }
}
