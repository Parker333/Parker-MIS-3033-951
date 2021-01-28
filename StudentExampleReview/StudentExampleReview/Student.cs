using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExampleReview
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColor { get; set; }
        public Student()
        {
            ID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            FavoriteColor = string.Empty;
        }
        public Student(int id, string first, string last, string color)
        {
            ID = id;
            FirstName = first;
            LastName = last;
            FavoriteColor = color;
        }
        public string CreateFullName()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}
