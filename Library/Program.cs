using ConsoleApp;
using Library.Domain;
using Persistence;
using System;
using System.Threading;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Login: ");
            string login = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            if(login == "Admin" && password == "password")
            {
                Console.WriteLine("Access Granted");
            } 
            else 
            {
                Console.WriteLine("Access Denied");
            }

            for (int i = 0; i < 3; ++i)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.Clear();

            bool AppRunning = true;
            BooksService service = new BooksService();


            while (AppRunning)
            {
                PrintMenu();
                Console.Write("Command: ");
                string command = Console.ReadLine();
                switch(command)
                {
                    case "dodaj":
                        HandleCommand(service.AddBook);
                        break;
                    case "usun":
                        HandleCommand(service.RemoveBook);
                        break;
                    case "wypisz":
                        HandleCommand(service.ListBooks);
                        break;
                    case "zmien":
                        HandleCommand(service.ChangeState);
                        break;
                    case "dodaj zamowienie":
                        HandleCommand("proba dodania nowego zamowienia");
                        break;
                    case "lista zamowien":
                        HandleCommand("proba wypisania wszystkich zamowien");
                        break;
                    case "wyjdz":
                        Console.Clear();
                        Console.WriteLine("Bye!");
                        AppRunning = false;
                        break;
                    default:
                        HandleCommand("Komenda nie jest wspierana");
                        break;
                }
            }
        }

        private static void HandleCommand(string output)
        {
            Console.Clear();
            Console.WriteLine(output);
            Console.WriteLine("Press AnyKey...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void HandleCommand(Action func)
        {
            Console.Clear();
            func();
            Console.WriteLine("Press AnyKey...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Commands: ");
            Console.WriteLine("dodaj");
            Console.WriteLine("usun");
            Console.WriteLine("wypisz");
            Console.WriteLine("zmien");
            Console.WriteLine("dodaj zamowienie");
            Console.WriteLine("lista zamowien");
        }
    }
}
