// See https://aka.ms/new-console-template for more information

using IM_P2;

Console.WriteLine("Hello, World!");

var hp1 = new Book("Harry Potter und der Stein der Weisen", "J.K. Rowling", DateOnly.Parse("2000-01-01"));
var orwell = new Book("1984", "George Orwell", DateOnly.Parse("2047-07-10"));

Console.WriteLine(hp1);
Console.WriteLine(orwell);

Library library = new Library();
library.AddBook(hp1);
library.AddBook(orwell);

foreach (var book in library.GetBooks())
{
    Console.WriteLine(book);
}