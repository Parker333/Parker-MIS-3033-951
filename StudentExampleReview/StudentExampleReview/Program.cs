using System;
using System.IO;

namespace StudentExampleReview
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("studentdataRandom100Rows.csv");

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }


        }
    }
}
