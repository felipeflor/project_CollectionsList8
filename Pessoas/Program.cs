using System;
using System.Collections.Generic;

namespace Pessoas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World Queue");

            Queue<string> listaPessoas = new Queue<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite nome a ser guardado na fila");
                string pessoa = Console.ReadLine();
                listaPessoas.Enqueue(pessoa);
            }

            Console.WriteLine($"Primeiro da fila: {listaPessoas.Dequeue()}");
            Console.WriteLine("Primeiro da fila será excluido");
            listaPessoas.Peek();
            Console.WriteLine($"Restam {listaPessoas.Count} na fila");

            foreach(string pessoas in listaPessoas)
            {
                Console.WriteLine($"Nome digitado: {pessoas}");
            }
        }
    }
}
