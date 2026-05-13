using System.Collections.Generic;

namespace LibraryApp.Models {
    public class Library {
        public List<Book> Books = new List<Book>();
        public void AddBook(Book book) => Books.Add(book);
    }
}