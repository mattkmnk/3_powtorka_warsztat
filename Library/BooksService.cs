using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class BooksService
    {
        public void AddBook()
        {
            Console.WriteLine("==== Dodawanie Ksiazki ====");
            Console.Write("Tytul: ");
            var title = Console.ReadLine();
            Console.Write("Autor: ");
            var author = Console.ReadLine();
            Console.Write("ISBN: ");
            var ISBN = Console.ReadLine();
            Console.Write("Rok publikacji: ");
            var publicationYear = Console.ReadLine();
            Console.Write("Dostepnych: ");
            var productAvailable = Console.ReadLine();
            Console.Write("Cena: ");
            var price = Console.ReadLine();
        }

        public void RemoveBook()
        {
            Console.WriteLine("==== Usuwanie Ksiazki =====");
            Console.Write("Tytul: ");
            var title = Console.ReadLine();
        }

        public void ListBooks()
        {
            Console.WriteLine("==== Lista Ksiazek ====");
        }

        public void ChangeState()
        {
            Console.WriteLine("==== Zmiana Stanu ====");
            Console.Write("Tytul: ");
            var title = Console.ReadLine();
            Console.Write("Zmiana: ");
            var change = Convert.ToInt32(Console.ReadLine());
        }
    }
}
