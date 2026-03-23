using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int YearOfPublication { get; set; }

        public Book() { }

        public Book(string name, string author, int yearOfPublication)
        {
            Name = name;
            Author = author;
            YearOfPublication = yearOfPublication;
        }
    }
}
