using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Data
{
    public class LibraryRepository
    {
        private readonly LibrariesContext _context;
        public LibraryRepository(LibrariesContext context)
        {
            _context = context;
        }
        public Library GetLibraryById(Guid id)
        {
            return _context.Libraries.Include(c=> c.Books.Select(b=> b.Pages)).SingleOrDefault(c => c.Id == id);
        }

        public void UpdateLibrary(Library library)
        {
            _context.SaveChanges();
        }
    }
}
