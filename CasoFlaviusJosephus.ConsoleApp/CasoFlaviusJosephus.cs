using System;

namespace CasoFlaviusJosephus.ConsoleApp
{
    internal class CasoFlaviusJosephus
    {
        static void Main(string[] args)
        {
            int numerodepesoas = 0;
            int numerodopulo = 0;
            string [] entrada ;
            int[] pessoastotal;

            Console.WriteLine("Suicidio coletivo");
            Console.WriteLine("Digite o numero de pessoas e o número de pulo:");
            entrada = Console.ReadLine().Split(" ");
            #region separando as entradas
            for (int i = 0; i <= entrada.Length; i++)
            {
                if (i == 0)
                {
                    numerodepesoas = Convert.ToInt32(entrada[i]);
                }
                if (i == 1)
                {
                    numerodopulo = Convert.ToInt32(entrada[i]);
                }
                
            }
            #endregion

            pessoastotal = new int [numerodepesoas];

            for(int i = 0;i < pessoastotal.Length; i++)
            {
                pessoastotal[i] = Convert.ToInt32(i);
                
            }
            

        }
    }
}
