using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _10_GenericTypesCollections.Models
{
    internal class BookManager
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public Dictionary<string, List<Book>> BooksByAuthor { get; set; } = new Dictionary<string, List<Book>>();
        public Queue<string>WaitingQueue { get; set; } = new Queue<string>();
        public Stack<Book> RecentlyReturned { get; set; } = new Stack<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
            if(!BooksByAuthor.ContainsKey(book.Author))
            {
                BooksByAuthor[book.Author] = new List<Book>();
            }
            BooksByAuthor[book.Author].Add(book);

        }

        public Book SearchByTitle(string title)
        {
            foreach(Book book in Books)
            {
                if(title==book.Title)
                {
                    return book;
                }
                
            }
            

                //Console.WriteLine($"Kitab tapilmadi:{title}");
            

            return null;
        }
        public List<Book> GetBooksByAuthor(string author)
        {
            if (BooksByAuthor.ContainsKey(author))
            {
                return BooksByAuthor[author];
            }
            return new List<Book>();
        }

        public void AddToWaitingQueue(string memberName)
        {
            WaitingQueue.Enqueue(memberName);
            Console.WriteLine($"{memberName} novbeye elave edildi");
        }

        public string ServeNextInQueue()
        {
            if(WaitingQueue.Count>0)
            {
                
                return WaitingQueue.Dequeue();
            }
            return null;
        }

        public void ReturnBook(Book book)
        {
            RecentlyReturned.Push(book);
            Console.WriteLine($"Kitab qebul edildi:{book.Title}");
        }

        public Book GetLastReturnedBook()
        {
            if (RecentlyReturned.Count >0)
            {
                return RecentlyReturned.Peek();
            }
            return null;
        }
    }
}

