using System;

namespace treinando_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Calculando juros em um empréstimo

            double valor_emprestimo, result;
            //juros de 20%;
            double parcelas;
            int operacao;            

            while(true)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t Vamos Calcular");
                Console.WriteLine();
                Console.ResetColor();
                Console.Write(" Informe o valor do empréstimo: ");
                valor_emprestimo = Convert.ToDouble(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t Taxa de juros de 20%");
                Console.ResetColor();
                Console.WriteLine(" Escolha a quantidade de parcelas");
                Console.WriteLine("\t 1x");
                Console.WriteLine("\t 2x");
                Console.WriteLine("\t 3x");
                Console.WriteLine("\t 4x");
                Console.WriteLine("\t 5x");
                Console.WriteLine("\t 6x");
                Console.WriteLine("\t 7x");
                Console.WriteLine("\t 8x");
                Console.WriteLine("\t 9x");
                Console.WriteLine("\t 10x");
                Console.WriteLine("\t 11x");
                Console.WriteLine("\t 12x");
                Console.WriteLine();
                Console.Write(" Informe a operação: ");
                operacao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch(operacao)
                {
                    case 1:                                        
                    result = (valor_emprestimo + ((valor_emprestimo * 20)/100));
                    parcelas = result / 1;
                    Console.WriteLine(" Você pagará uma vez de: " + parcelas.ToString("N2") + " reais");
                    break;

                    case 2:                    
                    result = (valor_emprestimo + ((valor_emprestimo * 20)/100));
                    parcelas = result / 2;
                    Console.WriteLine(" Você pagará duas vezes de " + parcelas.ToString("N2") + " reais");
                    break;

                    case 3:                   
                    result = (valor_emprestimo + ((valor_emprestimo * 20)/100));
                    parcelas = result / 3;
                    Console.WriteLine(" Você pagará três vezes de " + parcelas.ToString("N2") + " reais");
                    break;

                    case 4:                    
                    result = (valor_emprestimo + ((valor_emprestimo * 20)/100));
                    parcelas = result / 4;
                    Console.WriteLine(" Você pagará quatro vezes de " + parcelas.ToString("N2") + " reais");
                    break;

                    case 5:                
                    result = (valor_emprestimo + ((valor_emprestimo * 20)/100));
                    parcelas = result / 5;
                    Console.WriteLine(" Você pagará cinco vezes de " + parcelas.ToString("N2") + " reais");
                    break;

                    case 6:            
                    result = (valor_emprestimo + ((valor_emprestimo * 20)/100));
                    parcelas = result / 6;
                    Console.WriteLine(" Você pagará seis vezes de " + parcelas.ToString("N2") + " reais");
                    break;

                    case 7:                  
                    result = (valor_emprestimo + ((valor_emprestimo * 20)/100));
                    parcelas = result / 7;
                    Console.WriteLine(" Você pagará sete vezes de " + parcelas.ToString("N2") + " reais");
                    break;

                    case 8:             
                    result = (valor_emprestimo + ((valor_emprestimo * 20)/100));
                    parcelas = result / 8;
                    Console.WriteLine(" Você pagará oito vezes de " + parcelas.ToString("N2") + " reais");
                    break;

                    case 9:            
                    result = (valor_emprestimo + ((valor_emprestimo * 20)/100));
                    parcelas = result / 9;
                    Console.WriteLine(" Você pagará nove vezes de " + parcelas.ToString("N2") + " reais");
                    break;

                    case 10:        
                    result = (valor_emprestimo + ((valor_emprestimo * 20)/100));
                    parcelas = result / 10;
                    Console.WriteLine(" Você pagará dez vezes de " + parcelas.ToString("N2") + " reais");
                    break;

                    case 11:            
                    result = (valor_emprestimo + ((valor_emprestimo * 20)/100));
                    parcelas = result / 11;
                    Console.WriteLine(" Você pagará onze vezes de " + parcelas.ToString("N2") + " reais");
                    break;

                    case 12:            
                    result = (valor_emprestimo + ((valor_emprestimo * 20)/100));
                    parcelas = result / 12;
                    Console.WriteLine(" Você pagará doze vezes de " + parcelas.ToString("N2") + " reais");
                    break;

                    default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Tente Novamente.....");                
                    Console.WriteLine();
                    Console.ResetColor();
                    break;                    
                }
               Console.WriteLine();
               Console.WriteLine("..... Aperte uma tecla para continuar .....");
               Console.WriteLine();
               Console.ReadKey();             
            }            

        }
    }
}
