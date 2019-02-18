using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Book
    {
        public Book()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<Page> Pages { get; set; }
        public Library Library { get; set; }
    }
}
