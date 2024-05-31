using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapp.Pages;

public class IndexModel : PageModel
{
    
        public IList<Book> Books { get; set; }
        public string SearchTerm { get; set; }

        public void OnGet(string search)
        {
            SearchTerm = search;

            // Hard-coded list of books for demonstration purposes
            var allBooks = new List<Book>
            {
                new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925, CopyrightInfo = "© 1925 by F. Scott Fitzgerald" },
                new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960, CopyrightInfo = "© 1960 by Harper Lee" },
                new Book { Id = 3, Title = "1984", Author = "George Orwell", Year = 1949, CopyrightInfo = "© 1949 by George Orwell" },
                new Book { Id = 4, Title = "Moby Dick", Author = "Herman Melville", Year = 1851, CopyrightInfo = "© 1851 by Herman Melville" }
            };

            // Search functionality
            if (!string.IsNullOrEmpty(search))
            {
                Books = allBooks.Where(b => b.Title.Contains(search) || b.Author.Contains(search)).ToList();
            }
            else
            {
                Books = allBooks;
            }
        }
}
