using System;
using System.Collections.Generic;

namespace Animais
{
    public class Program
    {

        
        public static void Main(string[] args)
        {
            string animais;
            Console.WriteLine("Hello World List!");

            List<string> listaAnimais = new List<string>();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Informe {i}º nome a ser guardado na lista: ");
                animais = Console.ReadLine();
                listaAnimais.Add(animais);
            }

            

            Console.WriteLine("\n Informe animal na posição 2");
            animais = Console.ReadLine();
            listaAnimais.Insert(2, animais);

            listaAnimais.RemoveAt(4);
            listaAnimais.RemoveAt(1);

            foreach (string animal in listaAnimais)
            {
                Console.WriteLine($"Nome digitado: {animal}");
            }

        }
    }
}
