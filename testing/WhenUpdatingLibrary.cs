using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Effort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace testing
{
    [TestClass]
    public class WhenUpdatingLibrary
    {


        [TestMethod]
        public void TestUpdatingLibrary()
        {
            var connection = DbConnectionFactory.CreateTransient();
            var libraryId = Guid.NewGuid();
            var library = new Library(libraryId, "First Library");

            using (var context = new LibrariesContext(connection))
            {
                context.Libraries.Add(library);
                context.SaveChanges();
            }

            using (var context = new LibrariesContext(connection))
            {
                Assert.AreEqual(1, context.Libraries.Count());
                Assert.AreEqual(0, context.Books.Count());
                Assert.AreEqual(0, context.Pages.Count());
            }

            using (var context = new LibrariesContext(connection))
            {
                var repository = new LibraryRepository(context);
                var lib = repository.GetLibraryById(libraryId);
                AddBook(lib);
                repository.UpdateLibrary(lib);
            }

            using (var context = new LibrariesContext(connection))
            {
                Assert.AreEqual(1, context.Libraries.Count());
                Assert.AreEqual(1, context.Books.Count());
                Assert.AreEqual(1, context.Pages.Count());
            }

            using (var context = new LibrariesContext(connection))
            {
                var repository = new LibraryRepository(context);
                var lib = repository.GetLibraryById(libraryId);
                AddBook(lib);
                repository.UpdateLibrary(lib);
            }

            using (var context = new LibrariesContext(connection))
            {
                Assert.AreEqual(1, context.Libraries.Count());
                Assert.AreEqual(2, context.Books.Count());
                Assert.AreEqual(2, context.Pages.Count());
            }

        }

        private void AddBook(Library library)
        {
            library.Books.Add(new Book
            {
                Title = "Title",
                Pages = new List<Page>
                {
                    new Page
                    {
                        Content = "Some page content",
                        Number = 1
                    }
                }
            });
        }
    }
}
