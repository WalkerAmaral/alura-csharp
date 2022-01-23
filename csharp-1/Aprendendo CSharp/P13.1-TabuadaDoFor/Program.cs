using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(String[] args)
    {

        for (int numero = 1; numero <= 100; numero++)
        {

            if (numero % 3 == 0)
            {
                Console.Write(numero + " ");
            }
        }
        Console.WriteLine();
        Console.WriteLine();
        for (int numero = 3; numero <= 100; numero += 3)
        {
            Console.Write(numero + " ");
        }


        Console.ReadLine();
    }
}