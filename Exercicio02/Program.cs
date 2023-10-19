using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(5);
            numeros.Add(6);
            numeros.Add(7);
            numeros.Add(8);
            numeros.Add(9);
            numeros.Add(10);
            numeros.Add(11);
            numeros.Add(12);
            numeros.Add(13);
            numeros.Add(14);
            numeros.Add(15);
            
            foreach (int numero in numeros)
            {
                if ( numero % 2 == 0 )
                {
                    Console.WriteLine("Este número é par; " + numero);
                }
                else
                {
                    Console.WriteLine("este número é impar " + numero);
                }
            }
            
            Console.ReadKey();
        }
    }
}
