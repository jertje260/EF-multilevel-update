using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Data
{
    public class LibrariesContext : DbContext
    {
        public LibrariesContext(DbConnection connection): base(connection, false)
        {
            
        }

        public DbSet<Library> Libraries { get; set; } 
        public DbSet<Book> Books { get; set; }
        public DbSet<Page> Pages { get; set; }
    }
}
