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

namespace exerciseLibraryGroup
{
    internal class Program
    {
        //static Library library = new Library();

        static void Main(string[] args)
        {
           
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
                       break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Library.Exit();
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong input, try again...");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Thread.Sleep(2000);
                        break;
                }
            }
           
        }
       public class Book
        {
            public required string Title { get; set; }
            public required string Author { get; set; }
            public required string Borrow { get; set; }
            public bool Status { get; set; }




        }

        public class Library
        {
            public required List<Book> Books { get; set; }//Samuel testar utan public required på listorna
            public required List<Borrower> Borrowers { get; set; }

            public static void AddBook()
            {
                return;
            }

            public static void BorrowBooks()
            {
                return;
            }

            public static void Exit()//method for shutting down the program
            {
                Console.Clear();
                Console.WriteLine("Thanks for this time! Shutting down...");
                Environment.Exit(0);
            }

        }
        public class Borrower
        {
            public required string Name { get; set; }
            public int SocialSecurityNr { get; set; }
            public required string Titles { get; set; }

        }
    }
}
