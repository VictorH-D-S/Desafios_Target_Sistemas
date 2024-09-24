using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Desafio_Target_Sistemas
{
    internal class Program
    {
        // Programa que exibe o valor final da soma
        static void Main(string[] args)
        {
            int INDICE = 13, SOMA = 0, K = 0;
            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine($"A soma da operação é igual a: {SOMA}");
            Console.ReadKey();
        }
    }
}
