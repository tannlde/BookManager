using System;
using MyBookLibrary;
namespace BookManager
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBook managerBook = new();
            while (true)
            {
                Console.WriteLine("1. Add new book");
                Console.WriteLine("2. Update a book,");
                Console.WriteLine("3. Delete a book");
                Console.WriteLine("4. List all book");
                Console.WriteLine("5. Quit");
                Console.Write("Enter option: ");
                if (!int.TryParse(Console.ReadLine(), out int opt)){
                    Console.WriteLine("Must be from 1 to 5");
                }
                switch (opt)
                {
                    case 1:
                        managerBook.AddBook();
                        break;
                    case 2:
                        managerBook.UpdateABook();
                        break;
                    case 3:
                        managerBook.DeleteABook();
                        break;
                    case 4:
                        managerBook.ListBook();
                        break;
                    case 5:
                        return;
                }
            }
        }
    }
}
