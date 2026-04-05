using _10_GenericTypesCollections.Models;


  Console.OutputEncoding = System.Text.Encoding.UTF8;
List<Book> books = new List<Book>();
Book book1=new Book(1,"Martin Eden","Jack London",1909,400);
Book book2=new Book(2,"1984", "George Orwell", 1949,328);
Book book3=new Book(3, "Animal Farm", "George Orwell", 1945,112);
Book book4=new Book(4, "Ağ Gəmi", "Cingiz Aytmatov", 1970,200);
Book book5=new Book(5, "Qırıq Budaq", "Elçin", 1998,350);
books.Add(book1);
books.Add(book2);
books.Add(book3);
books.Add(book4);
books.Add(book5);

book1.DisplayInfo();
book2.DisplayInfo();
book3.DisplayInfo();
book4.DisplayInfo();
book5.DisplayInfo();

Library<Book> library = new Library<Book>("Milli Kitabxana");
library.Add(book1);
library.Add(book2);
library.Add(book3);
library.Add(book4);
library.Add(book5);

Console.Write("Umumi kitab sayi: ");
Console.WriteLine(library.ItemCount());
Console.WriteLine(library.FindByIndex(0));
Console.WriteLine(library.FindByIndex(2));


library.GetAll().ForEach(book => Console.WriteLine(book));



Member member1 = new Member(1, "Ali Memmedov", "ali@mail.com");
Member member2 = new Member(2, "Leyla Həsənova", "leyla@mail.com");
Member member3 = new Member(3, "Vüqar Əliyev", "vuqar@mail.com");
List <Member> members = new List<Member>();
members.Add(member1);
members.Add(member2);
members.Add(member3);

member2.BorrowBook(book1);
member2.BorrowBook(book2);
member2.DisplayBorrowBooks();

member2.ReturnBook(1);
member2.DisplayBorrowBooks();
member2.BorrowBook(book3);
member2.BorrowBook(book4);
member2.BorrowBook(book5);
member2.BorrowBook(book1);


BookManager bookManager = new BookManager();

bookManager.AddBook(book1);
bookManager.AddBook(book2);
bookManager.AddBook(book3);
bookManager.AddBook(book4);
bookManager.AddBook(book5);
Console.WriteLine("George Orwell:");
bookManager.GetBooksByAuthor("George Orwell").ForEach(book => Console.WriteLine(book));
Console.WriteLine("Cingiz Aytmatov:");
bookManager.GetBooksByAuthor("Cingiz Aytmatov").ForEach(book => Console.WriteLine(book));
Console.WriteLine("Jack London:");
bookManager.GetBooksByAuthor("Jack London").ForEach(book => Console.WriteLine(book));
bookManager.GetBooksByAuthor("Dostoyevski").ForEach(book => Console.WriteLine(book));


bookManager.AddToWaitingQueue("Nigar");
bookManager.AddToWaitingQueue("Resad");
bookManager.AddToWaitingQueue("Sebine");

Console.WriteLine("Xidmet edilir "+bookManager.ServeNextInQueue());
Console.WriteLine("Xidmet edilir "+bookManager.ServeNextInQueue());
Console.WriteLine("Xidmet edilir "+bookManager.ServeNextInQueue());
Console.WriteLine("Xidmet edilir "+bookManager.ServeNextInQueue());


bookManager.ReturnBook(book1);
bookManager.ReturnBook(book2);
bookManager.ReturnBook(book3);
Console.WriteLine(bookManager.RecentlyReturned.Count());
Console.WriteLine(bookManager.GetLastReturnedBook());
bookManager.RecentlyReturned.Pop();
Console.WriteLine(bookManager.RecentlyReturned.Count());
Console.WriteLine(bookManager.GetLastReturnedBook());

Console.WriteLine(bookManager.SearchByTitle("1984"));
Console.WriteLine(bookManager.SearchByTitle("Harry Potter"));

Console.WriteLine($"Umumi kitab sayi: {books.Count}");
Console.WriteLine($"Umumi uzv sayi: {members.Count}");
Console.WriteLine($"Umumi novbede nefer sayi: {bookManager.WaitingQueue.Count}");
Console.WriteLine($"Umumi Stackda kitab sayi: {bookManager.RecentlyReturned.Count}");

var min = library.GetAll()[0].Year;
var max = library.GetAll()[4].Year;
Console.WriteLine("En kohne kitab:");
foreach(Book item in library.GetAll())
{
    if (min >= item.Year)
    {
        min = item.Year;
        Console.WriteLine(item.Title);
    }

}

Console.WriteLine("En teze kitab:");
foreach (Book item in library.GetAll())
{
    if (max <= item.Year)
    {
        max = item.Year;
        Console.WriteLine(item.Title);
    }
}

















