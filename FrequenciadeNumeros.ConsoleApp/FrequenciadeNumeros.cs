using System;

namespace FrequenciadeNumeros.ConsoleApp
{
    internal class FrequenciadeNumeros
    {
        static void Main(string[] args)
        {
            int quantidadedenumeros;
            int[] numerosarmazenados;
            int[] numerosrepetidos;
            int[] quantidadesrepetidas;
            


            Console.WriteLine("Quantos numeros você vai digitar?");
            quantidadedenumeros = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite os numeros");
            numerosarmazenados = new int[quantidadedenumeros];
            numerosrepetidos = new int[quantidadedenumeros];

            #region recebendo os numeros
            for (int i = 0; i < numerosarmazenados.Length; i++)
            {
                numerosarmazenados[i] = Convert.ToInt32(Console.ReadLine());
            }
            #endregion

            Array.Sort(numerosarmazenados);


            for (int i = 0; i < numerosarmazenados.Length; i++)
            {
               numerosrepetidos[i] = numerosarmazenados[i];
            
            }

            foreach(int i in numerosarmazenados)
            {
                if(numerosrepetidos[i] == numerosarmazenados[i])
                {
                    puts
                }
            }
            


        }
    }
}
