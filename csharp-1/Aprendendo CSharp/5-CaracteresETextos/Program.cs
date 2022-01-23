using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5");

            char primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia " + 2021;
            string cursos = @" - .NET
 - Java
 - JavaScript
 - Python";
            
            Console.WriteLine(titulo);
            Console.WriteLine(cursos);
            Console.WriteLine("TecleEnter");
            Console.ReadLine();
        }
    }
}
