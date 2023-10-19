using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade1 = 10;
            int idade2 = 12;
            int idade3 = 14;
            int idade4 = 16;
            int idade5 = 18;

            int somaTotal = idade1 + idade2 + idade3 + idade4 + idade5;

            int media = somaTotal / 5;

            Console.WriteLine($"A idade média dos alunos da classe é de {media} anos");

            Console.ReadKey();
        }
    }
}
