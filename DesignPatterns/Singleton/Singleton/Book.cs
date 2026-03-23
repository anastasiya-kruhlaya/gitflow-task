using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Book
    {
        private string? _title;
        public string? _author;
        public Book(string title, string author)
        {
            _title = title;
            _author = author;
        }
        public override string ToString()
        {
            return $"{_title}, {_author}";
        }
    }
}
