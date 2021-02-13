using System;
using System.Collections.Generic;
using System.Text;

namespace Wpf1_Classes
{
   public class Info
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Zipcode { get; set; }

        public Info()
        {
            Name = string.Empty;
            Address = string.Empty;
            Zipcode = 0;
        }

        public override string ToString()
        {
            return $"Name: {Name} \n Address: {Address} \n Zipcode: {Zipcode}";
        }
    }
}
