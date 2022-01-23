using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            int salarioEmInteiro = (int)salario;
           
            long idade = 13000000000;

            short quantidadeProdutos = 150;

            float altura = 1.80f;

            Console.WriteLine(idade);
            Console.WriteLine(altura);
            Console.WriteLine(quantidadeProdutos);
            Console.WriteLine(salarioEmInteiro);
            Console.WriteLine(salario);
            Console.ReadLine();
        }
    }
}
