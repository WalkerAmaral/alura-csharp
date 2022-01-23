using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario();
            
            carlos.Nome = "Carlos";
            carlos.CPF = "056.442.631-85";
            carlos.Salario = 2000;

            Console.WriteLine(carlos.GetBonificacao());
            Console.ReadLine();
            
        }
    }
}
