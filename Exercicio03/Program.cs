using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();

            idades.Add(12);
            idades.Add(14);
            idades.Add(22);
            idades.Add(35);
            idades.Add(18);
            idades.Add(15);
            idades.Add(12);
            idades.Add(14);
            idades.Add(10);
            idades.Add(88);
            idades.Add(65);

            int quantidadeDePessoasMaioresDe18 = 0;


            foreach (var idade in idades)
            {
                if (idade >= 18)
                {
                    quantidadeDePessoasMaioresDe18++;

                }


            }

            Console.WriteLine(quantidadeDePessoasMaioresDe18);





            Console.ReadKey();
        }
    }
}
