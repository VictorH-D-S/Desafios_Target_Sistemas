using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Desafio_Target_Sistemas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que exibe a porcentagem de faturamento mensal detalhado por Estado

            string[] estados = { "SP", "RJ", "MG", "ES", "Outros" };
            double[] faturamentos = { 67836.43, 36678.66, 29229.88, 27165.48, 19849.53 };

            double totalFaturamento = 0;
            foreach (double valor in faturamentos)
            {
                totalFaturamento += valor;
            }

            Console.WriteLine("Percentual de representação de cada estado:");
            for (int i = 0; i < estados.Length; i++)
            {
                double percentual = (faturamentos[i] / totalFaturamento) * 100;
                Console.WriteLine($"{estados[i]}: {percentual:F2}%");        
            }
            Console.ReadKey();
            return;
        }
    }
}
