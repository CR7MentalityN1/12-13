using LibraryApp.Models;
using System.Linq;

namespace LibraryApp.Services {
    public class LibraryService {
        private Library _library;
        public LibraryService(Library library) => _library = library;

        public void BorrowBook(int id) {
            var book = _library.Books.FirstOrDefault(b => b.Id == id);
            if (book != null) book.IsAvailable = false;
        }
    }
}