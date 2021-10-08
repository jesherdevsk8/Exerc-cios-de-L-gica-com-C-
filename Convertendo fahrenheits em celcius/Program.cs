using System;

namespace Convertendo_F_º_em_C_º___fazer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*fazer um aplicativo que converta graus fahrenheits em graus celcius
            a formula será c = f - 32 / 1,8
            */

            int fahrenheits;
            double celcius;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tConvertendo Fahrenheits em Celcius");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write(" Informe a quantidade de fahrenheits: ");
            fahrenheits = int.Parse(Console.ReadLine());

            celcius = (fahrenheits - 32) / 1.8;

            Console.WriteLine();
            Console.WriteLine(" O resultado é: " + celcius.ToString("N2"));
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
