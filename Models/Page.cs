using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Page
    {
        public Page()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Content { get; set; }
        public Book Book { get; set; }
    }
}
