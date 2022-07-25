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
            
            Console.WriteLine("Please inform the quantity of books to be registred");
            int y = Convert.ToInt32(Console.ReadLine());

            string x = "";
            for(int i = 0; i <y; i++)
            {
                Console.WriteLine("Type the name of the book for registration: ");
                x = Console.ReadLine();
                books.Push(x);
                string lastBook = x;
                
            }
            Console.WriteLine($"The first book is: {x}");
            
            int qtd = books.Count;
            Console.WriteLine($"The quantity of books are: {qtd}\n\n" +
                $"Now, we are going to delete the first book and show again the list\n");
          
            books.Pop();

            foreach (String book in books)
            {
                Console.WriteLine(book);
            }



        }
    }
}
