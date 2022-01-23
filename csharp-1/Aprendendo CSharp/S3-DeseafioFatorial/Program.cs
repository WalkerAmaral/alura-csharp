using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_DeseafioFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Desafio");

            /*int fatorial4 = 4 * 3 * 2 * 1;

            Console.WriteLine(fatorial4);

            O fatorial de 0 é 1.
            O fatorial de 1 é (0!) * 1 = 1.
            O fatorial de 2 é (1!) * 2 = 2
            O fatorial de 3 é (2!) * 3 = 6
            O fatorial de 4 é (3!) * 4 = 24

            */
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {

                fatorial = fatorial * n;
                Console.WriteLine("O fatorial de " + n + " é: " + fatorial);


                /* 
                n == 2
                fatorial == 1

                fatorial = n * 1
                */
            }

                

            Console.ReadLine();
        }
    }
}
