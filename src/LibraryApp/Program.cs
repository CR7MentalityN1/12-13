using System;
using LibraryApp.Models;
using LibraryApp.Services;

var myLib = new Library();
var service = new LibraryService(myLib);

myLib.AddBook(new Book(1, "1984", "George Orwell"));
myLib.AddBook(new Book(2, "Master and Margarita", "M. Bulgakov"));

Console.WriteLine("Библиотека до выдачи:");
myLib.Books.ForEach(Console.WriteLine);

service.BorrowBook(1);

Console.WriteLine("\nПосле выдачи (ID 1):");
myLib.Books.ForEach(Console.WriteLine); 