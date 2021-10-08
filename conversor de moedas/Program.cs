using System;

namespace treinando_3
{
    class Program
    {

        /*conversor de moedas..... Para viajar ao exterior, devo comprar quantidade X de dolares, mas
        para isso veremos quantos reais possuo em mãos*/
        static void Main(string[] args)
        {

            //valor do dólar nesse exato momento 31/05/2021 = é equivalente à 5,21 reais
            double reais, dolares;

            Console.WriteLine("____ Comprando dolares ____");
            Console.WriteLine();

            Console.Write(" Quantos reais eu tenho? ");
            reais = Convert.ToDouble(Console.ReadLine());

            dolares = reais/5.21;
            
            Console.WriteLine();
            Console.WriteLine(" Posso ter US$ " + dolares);
            Console.WriteLine();

            /* agora vamos converter o valor de um Tesla em reais brasileiros
            O Tesla escolhido é o modelo model 3 que é um modelo mais em conta e
            custa em torno de US$ 35 mil dólares */

            double Valor_Reais;
            double Valor_Dolares;

            Console.WriteLine("____ Convertendo Valor do Tesla model 3 para reais brasileiros ____");            
            Console.WriteLine(" Valor dele é US$ 35000 Dólares");
            Console.WriteLine();

            Console.Write(" Informe o valor do modelo: ");
            Valor_Dolares = Convert.ToDouble(Console.ReadLine());

            Valor_Reais = Valor_Dolares * 5.21;

            Console.WriteLine();
            Console.WriteLine(" O valor do Tesla em reais é " + Valor_Reais + " mil ");
            Console.WriteLine();



        }
    }
}
