using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12_06_2024
{
    internal class Book
    {
        public string Name { get; set; }
        public string Title { get; set; }

        public Book(string name, string title)
        {
            Name = name;
            Title = title;
        }

        public static bool operator==(Book left, Book right)
        {
            
            
          if (left.Name == right.Name && left.Title == right.Title)
          {
            return true;
          }       
            return false;
        }
        public static bool operator!= (Book a, Book b)
        {
            if (a.Name != b.Name && a.Title!=b.Title)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nTitle: {Title}";
        }
    }
}
