using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Desafio_Target_Sistemas
{
    internal class Program
    {
        public static string InverterString(string str)
        {
            // Programa para reverter os caracteres em uma variável string

            string resultado = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                resultado += char.ToLower(str[i]);
            }
            return resultado;

        }

        static void Main(string[] args)
        {
            Console.Write("Digite uma string para inverter: ");
            string texto = Console.ReadLine();

            Console.WriteLine("String invertida: " + InverterString(texto));
            Console.ReadKey();
            return;
        }
    }
}
