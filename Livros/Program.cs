using System;
using System.Collections.Generic;

namespace Livros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the exercise Stack - Collections!\n");

            Stack<string> books = new Stack<string>();
            books.Push("Genesis");
            books.Push("Exodus");
            books.Push("Leviticus");
            books.Push("Numbers");
            books.Push("Deuteronomy");

            foreach (String book in books)
            {
                Console.WriteLine(book);
            }

            int qtd = books.Count;
            Console.WriteLine($"The quantity of books are: {qtd}\n\n" +
                $"Now, we are going to delete the first book and show again the list\n");


            books.Contains("Deuteronomy");
            
            books.Pop();



            foreach (String book in books)
            {
                Console.WriteLine(book);
            }



        }
    }
}
