using System;

namespace teste
{
    class Program
    {    // ---> fazendo um conversor de bitcoins <---
        static void Main(string[] args)
        {
            //valor do bitcoin hoje 31/05/2021 = 192.817 Real Brasileiro
            
            double resultado, bitcoins = 0;
            int ano_nascimento, ano_atual;
            int idade;

         while (true)
         {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tVamos ver sua idade e teu valor de bitcoins em reais xDDD ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Iniciando.................");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" Cada ano de idade é equivalente a um bitcoin e converteremos o seu valor em reais brasileiros xD !!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" O valor do bitcoins está na casa de 192.817 mil reais neste momento");
            Console.ResetColor();
            Console.WriteLine();
            Console.Write(" Informe o ano de nascimento: ");
            ano_nascimento = int.Parse(Console.ReadLine());
            Console.Write(" Informe o ano em que estamos: ");
            ano_atual = int.Parse(Console.ReadLine()); 

            if (ano_nascimento >= ano_atual || ano_atual == 0 || ano_nascimento == 0 || ano_atual > 2021 || ano_atual < 2021)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t--XX-- E R R O R --XX--");
                Console.ResetColor();
                break;
            }                
            else           

            idade = (ano_atual - ano_nascimento);
            bitcoins = idade;
            Console.ForegroundColor = ConsoleColor.Cyan; 
            Console.WriteLine("\tVocê tem " + idade + " anos de idade e vale " + bitcoins + " bitcoins");                

            resultado = idade * 193000;            
            
            Console.ForegroundColor = ConsoleColor.Yellow;            
            Console.WriteLine("\tTeu valor é de R$ {0} ", resultado + " reais brasileiros");
            Console.ForegroundColor = ConsoleColor.Cyan;        
            Console.ResetColor();                                   
            Console.WriteLine("\t xD xD xD xD");
            Console.WriteLine();          
         }      

         
        }
    }
}
