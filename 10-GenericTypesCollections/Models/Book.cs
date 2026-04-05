using System;
using System.Collections.Generic;
using System.Text;

namespace _10_GenericTypesCollections.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int PageCount { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Title}";
        }

        public Book(int id, string title, string author, int year, int pagecount)
        {
            Id=id;
            Title=title;
            Author=author;
            Year=year;
            PageCount=pagecount;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Id:{Id}, {Title}- {Author}({Year})-{PageCount} sehife");
        }
    }
}
