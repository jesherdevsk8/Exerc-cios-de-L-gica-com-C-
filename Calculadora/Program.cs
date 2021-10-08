using System;

namespace aula_26._05._2021
{
    class Program
    {
        //Desenvolver um aplicativo com Menu
        static void Main(string[] args)
        {
            //declarando variaveis para inicialização com zero. 
            double num01 = 0;
            double num02 = 0;
            //double result;
            string acao = "";
            
            //titulo de exibição no terminal
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t Console Aplication ");
            Console.WriteLine("\t Calculadora em C# ");
            Console.WriteLine("");            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t A - Adição");
            Console.WriteLine("\t S - Subtração"); 
            Console.WriteLine("\t M - Multiplicação");
            Console.WriteLine("\t D - Divisão");
            Console.WriteLine("\t F - Fechar");

            Console.ResetColor();
            Console.Write(" Informe a Operação: ");
            acao = Console.ReadLine().ToUpper(); // <- ToUpper para receber a operação Maiúscula se ela for digitada em minusculo

            Console.WriteLine();            

            while (acao != "F")
            {
                if (acao == "A")
                {
                    //Pedindo ao usúario para digitar os números
                    Console.Write(" Digite o primeiro Número: ");
                    num01 = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write(" Digite o segundo número: ");
                    num02 = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    
                    Console.WriteLine($" O Resultado de: {num01} + {num02} = " + (num01 + num02));                                 
                }
                else if (acao == "S")
                {   
                    Console.Write(" Digite o primeiro Número: ");
                    num01 = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write(" Digite o segundo número: ");
                    num02 = double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine($" O Resultado de: {num01} - {num02} = " + (num01 - num02));

                }

                else if (acao == "M")
                {
                    Console.Write(" Digite o primeiro Número: ");
                    num01 = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write(" Digite o segundo número: ");
                    num02 = double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine($" O Resultado de: {num01} x {num02} = " + (num01 * num02));
                }

                else if (acao == "D")
                
                {
                    Console.Write(" Digite o primeiro Número: ");
                    num01 = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write(" Digite o segundo número: ");
                    num02 = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                   
                    if(num01 == 0 || num02 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" NÃO EXISTE DIVISÃO POR ZERO");
                        Console.ResetColor();
                    }
                    else
                    {
                         Console.WriteLine($" O Resultado de: {num01} ÷ {num02} = " + (num01 / num02)); //alt + 0247 para fazer o caractere de divisão
                    }
                   
                }

                else
                {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("");
                        Console.WriteLine(" -->> DADOS INVÁLIDOS <<--");
                        Console.WriteLine("");
                        Console.ResetColor();
                }

            Console.WriteLine("");
            Console.WriteLine(" -------> Pressione uma tecla <--------");
            Console.WriteLine("");
            Console.ReadKey();

            Console.Clear();

            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t Console Aplication ");
            Console.WriteLine("\t Calculadora em C# ");
            Console.WriteLine("");            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t A - Adição");
            Console.WriteLine("\t S - Subtração"); 
            Console.WriteLine("\t M - Multiplicação");
            Console.WriteLine("\t D - Divisão");
            Console.WriteLine("\t F - Fechar");

            Console.ResetColor();
            Console.Write(" Informe a Operação: ");
            acao = Console.ReadLine().ToUpper();

            Console.WriteLine();

            }
        }
    }
}
