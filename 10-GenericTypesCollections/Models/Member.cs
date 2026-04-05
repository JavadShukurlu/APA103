using System;
using System.Collections.Generic;
using System.Text;

namespace _10_GenericTypesCollections.Models
{
    internal class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Book> BorrowedBooks { get; set; } = new List<Book>();

        public Member(int id, string name, string email)
        {
            Id=id;
            Name=name;
            Email=email;
         
        }

        public void BorrowBook(Book book)
        {
            if (BorrowedBooks.Count > 3) 
            {
                Console.WriteLine("Maksimum 3 kitab goture bilersiniz");
            }

            else
            {
                BorrowedBooks.Add(book);
                Console.WriteLine($"Kitab goturuldu:{book.Title}");
            }
        }

        public void ReturnBook(int bookId)
        {
            foreach(Book book in BorrowedBooks)
            {
                if (bookId == book.Id)
                {
                    BorrowedBooks.Remove(book);
                    Console.WriteLine($"Kitab qaytarildi:{book.Title}");
                    break;
                }
                else
                {
                    Console.WriteLine($"{bookId} idli kitab goturulmemisdir.");
                }
            }
        }

        public void DisplayBorrowBooks()
        {
            if (BorrowedBooks.Count == 0)
            {
                Console.WriteLine("Borc kitab yoxdur");
            }

            foreach(Book book in BorrowedBooks)
            {
                Console.WriteLine($"Id:{book.Id}, {book.Title}- {book.Author}({book.Year})-{book.PageCount} sehife");
            }
        }
    }
}
