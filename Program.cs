/*
 Skapa ett system för bibliotek
Du ska skapa ett objektorienterat program i C# för att hantera utlåning och återlämning av böcker i ett bibliotek. 
Programmet ska möjliggöra för bibliotekspersonal att registrera nya böcker, låna ut böcker till låntagare, 
ta emot återlämnade böcker samt visa information om tillgängliga böcker och låntagare.
Skapa klasser för:
•	Bok (med egenskaper som titel, författare, låntagare, utlåningsstatus etc.).
•	Bibliotek (som hanterar en samling av böcker och låntagare).
•	Låntagare (med egenskaper som namn, personnummer, lånade böcker etc.).
Implementera funktioner för att:
•	Lägga till nya böcker i biblioteket.
•	Låna ut böcker till låntagare.
•	Återlämna böcker.
•	Visa tillgängliga böcker.
•	Visa låntagare och deras lånade böcker.
Använd listor och/eller andra lämpliga datastrukturer/filer för att hantera samlingar av böcker och låntagare.
Skapa ett användargränssnitt (konsol-baserat eller GUI) där bibliotekspersonal kan interagera med programmet och 
utföra ovanstående åtgärder. Skapa en användarvänlig och intuitiv design för användargränssnittet. 
Testa programmet genom att låna ut och återlämna böcker samt visa korrekt information om tillgängliga böcker och låntagare.

Jobba i grupper.
 */

using System.Net;
using System.Linq;

namespace exerciseLibraryGroup
{
    internal class Program
    {
        //static Library library = new Library();

        static void Main(string[] args)
        {
            Library library = new Library();
            bool myBool = true;
            while (myBool)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Welcome to the library!");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("[1] - Add books to the library.");
                Console.WriteLine("[2] - Borrow books from the library.");
                Console.WriteLine("[3] - Return books to the library.");
                Console.WriteLine("[4] - Show available books.");
                Console.WriteLine("[5] - Show who borrowed and which books.");
                Console.WriteLine("[6] - Exit program.");
                Console.WriteLine("------------------------------------------");
                Int32.TryParse(Console.ReadLine(), out int input);
                switch (input)
                {
                    case 1:
                        library.AddBook();
                       break;
                    case 2:
                        library.BorrowBooks();
                        break;
                    case 3:
                        break;
                    case 4:
                        library.ShowBooks();
                        break;
                    case 5:
                        break;
                    case 6:
                        Library.Exit();
                        break;
                    default:
                        Library.ErrorMessage("Invalid input...");
                        break;
                }
            }
           
        }
       public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Borrow { get; set; }
            public bool Status { get; set; }
            public string Name { get; set; }
            public int SocNr { get; set; }

            public Book(string title, string author) 
            {
               this.Title = title;
                this.Author = author;
                this.Status = true;
            }

            public Borrower(string name, int socNr) 
            {
                this.Name = name;
                this.SocNr = SocNr;
            }
        }

        public class Library
        {
            public List<Book> books { get; } = new List<Book>();
            public List<Borrower> borrowers { get; } = new List<Borrower>();



            public void AddBook()
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("What is the name of the book?");
                    string title = Console.ReadLine();
                    Console.WriteLine("Who is the author?");
                    string author = Console.ReadLine();
                    if(!string.IsNullOrEmpty(author) && !string.IsNullOrEmpty(title)) 
                    {
                        Book newBook = new Book(title, author);
                        books.Add(newBook);
                        Console.WriteLine("The book has been added.");
                        Thread.Sleep(1500);
                        return;
                    }
                    else
                    {
                        Library.ErrorMessage("You have to enter both title and author..");
                    }
                }
            }

            public void BorrowBooks()
            {
                while (true)
                {
                    Console.WriteLine("Enter your name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter social security number:");
                    string socNr = Console.ReadLine();
                    if (!string.IsNullOrEmpty(name) && socNr  )
                    {
                        Borrower borrow = new Borrower(name, socNr);
                        borrowers.Add(borrow);
                        Console.WriteLine("Your information is saved in our systems.");
                        continue;
                    }
                    else
                    {
                        Library.ErrorMessage("Enter valid name and social security number..");
                        continue;
                    }
                    Console.WriteLine("What book do you wish to borrow?");
                    string bookWish = Console.ReadLine();
                    if (books.Any(book => book.Title == bookWish))
                    {
                        Console.WriteLine("The book is available.");
                        books.RemoveAll(book => book.Title == bookWish);
                        Thread.Sleep(2000);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("The book is not available.");
                    }
                    break;   
                }
            }

            public static void Exit()//method for shutting down the program
            {
                Console.Clear();
                Console.WriteLine("Thanks for this time! Shutting down...");
                Environment.Exit(0);
            }

            public static void ErrorMessage(string message)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(2000);
            }

            public void ShowBooks()
            {
                Console.Clear();
                if (books.Count == 0)
                {
                    Console.WriteLine("There are no books.");
                    Thread.Sleep(1500);
                    return;
                }
                else
                {
                    Console.WriteLine("List of books in the library:");
                    foreach (var book in books)
                    {
                        Console.WriteLine($"Title: {book.Title}, author: {book.Author}.");
                    }
                }
                Console.WriteLine("Press X to continue.");
                while (Console.ReadKey(true).Key != ConsoleKey.X) { }
                Console.Clear();
            }
        }

        public class Borrower
        {
            public string Name { get; set; }
            public int SocialSecurityNr { get; set; }
            public string Titles { get; set; }
        }
    }
}
