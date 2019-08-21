using System.Collections.Generic;
using Biblioteca.API.Models;

namespace Biblioteca.API
{
    public class BooksDataStore
    {
        public static BooksDataStore Current { get; } = new BooksDataStore();
        public List<BookDto> Books { get; set; }

        public BooksDataStore()
        {
            Books = new List<BookDto>()
            {
                new BookDto
                {
                    Id = 1,
                    Name = "Book1",
                    Author = "Author1",
                    PublicationYear = 2002
                },
                new BookDto
                { 
                    Id = 2,
                    Name = "Book2",
                    Author = "Author2",
                    PublicationYear = 2003 
                },
            };
        }
    }
}