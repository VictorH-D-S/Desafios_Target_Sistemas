using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Desafio_Target_Sistemas
{
    internal class Program
    {
        class Faturamento
        {
            // Programa que guarda e exibe os valor de faturamento diario
            // Retorna o menor faturamento, o maior e a quantidade de dias em que o faturamento foi maior que a média mensal.

            public int Dia {get; set;}
            public double Valor {get; set;}

            public Faturamento(int dia, double valor)
            {
                Dia = dia;
                Valor = valor;
            }
        }
        static void Main(string[] args)
        {
            List<Faturamento> faturamentos = new List<Faturamento>
        {
            new Faturamento(1, 22174.1664),
            new Faturamento(2, 24537.6698),
            new Faturamento(3, 26139.6134),
            new Faturamento(4, 0.0),
            new Faturamento(5, 0.0),
            new Faturamento(6, 26742.6612),
            new Faturamento(7, 0.0),
            new Faturamento(8, 42889.2258),
            new Faturamento(9, 46251.174),
            new Faturamento(10, 11191.4722),
            new Faturamento(11, 0.0),
            new Faturamento(12, 0.0),
            new Faturamento(13, 3847.4823),
            new Faturamento(14, 373.7838),
            new Faturamento(15, 2659.7563),
            new Faturamento(16, 48924.2448),
            new Faturamento(17, 18419.2614),
            new Faturamento(18, 0.0),
            new Faturamento(19, 0.0),
            new Faturamento(20, 35240.1826),
            new Faturamento(21, 43829.1667),
            new Faturamento(22, 18235.6852),
            new Faturamento(23, 4355.0662),
            new Faturamento(24, 13327.1025),
            new Faturamento(25, 0.0),
            new Faturamento(26, 0.0),
            new Faturamento(27, 25681.8318),
            new Faturamento(28, 1718.1221),
            new Faturamento(29, 13220.495),
            new Faturamento(30, 8414.61)
        };
            var faturamentosValidos = faturamentos.Where(f => f.Valor > 0).ToList();

            double menorFaturamento = faturamentosValidos.Min(f => f.Valor);

            double maiorFaturamento = faturamentosValidos.Max(f => f.Valor);

            double mediaMensal = faturamentosValidos.Average(f => f.Valor);

            int diasAcimaDaMedia = faturamentosValidos.Count(f => f.Valor > mediaMensal);

            Console.WriteLine($"Menor valor de faturamento: R$ {menorFaturamento:F2}");
            Console.WriteLine($"Maior valor de faturamento: R$ {maiorFaturamento:F2}");
            Console.WriteLine($"Número de dias com faturamento superior à média mensal: {diasAcimaDaMedia}");
            Console.ReadKey( );
            return;
        }
    }
}

