using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Library
    {
        public Library()
        {
            Id = Guid.NewGuid();
            Books = new List<Book>();
        }

        public Library(Guid id, string name)
        {
            Id = id;
            Name = name;
            Books = new List<Book>();
        }

        public Library(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Books = new List<Book>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }
}
}
