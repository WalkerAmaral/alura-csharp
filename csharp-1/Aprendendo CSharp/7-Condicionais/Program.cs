﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7");

            int idadeJoao = 16;
            int quantidadePessoas = 2;
            if(idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode Entrar");
            } 
            else
            {
                if(quantidadePessoas >=2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado. Pode entrar");
                }
                else 
                {
                    Console.WriteLine("João é menor de idade. Não pode entrar");
                }

            }

            Console.ReadLine();
        }
    }
}