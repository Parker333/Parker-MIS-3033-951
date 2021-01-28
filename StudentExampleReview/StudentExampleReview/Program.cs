using System;
using System.Collections.Generic;
using System.IO;

namespace StudentExampleReview
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("studentdataRandom100Rows.csv");
            List<Student> students = new List<Student>();

            //Student s = new Student(5, "Joe", "Bob", "Blue");
            //Student s2 = new Student();
            //s2.FirstName = "Bob";
            //s2.LastName = "Joe";

           // foreach (var line in lines)
            //{
               // Console.WriteLine(line);
            //}

            for (int i = 1; i < lines.Length; i++)
            {
                string file = lines[i];
                var pieces = file.Split(',');
                Int64 id = Convert.ToInt64(pieces[0]);

                Student currentStudent = new Student(Convert.ToInt64(pieces[0]), pieces[1], pieces[2], pieces[3]);

                students.Add(currentStudent);
            }

            for (int i = 1; i < lines.Length; i++)

                PrintStudentsWithFavoriteColor("Blue");
                
            


        }
    }
}
