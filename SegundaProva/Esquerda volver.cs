using System;

namespace SegundaProva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerodecomando = 0;
            string comandosrecebidos = "";
            string lado = "N";
            string opcao = "1";

            Console.WriteLine("Digite o tanto de comandos: ");
            numerodecomando = Convert.ToInt32(Console.ReadLine());

            while (opcao == "1")
            {
                if (numerodecomando > 0)
                {
                    Console.WriteLine("Digite os comandos: ");
                    comandosrecebidos = Console.ReadLine();
                    comandosrecebidos = comandosrecebidos.ToUpper();





                    foreach (char comando in comandosrecebidos.ToCharArray())
                    {
                        #region lado esquerdo
                        if (comando == 'E' && lado == "N")
                        {
                            lado = "O";
                        }
                        else if (comando == 'E' && lado == "O")
                        {
                            lado = "S";
                        }
                        else if (comando == 'E' && lado == "S")
                        {
                            lado = "L";
                        }
                        else if (comando == 'E' && lado == "L")
                        {
                            lado = "N";
                        }
                        #endregion

                        #region lado direito
                        if (comando == 'D' && lado == "N")
                        {
                            lado = "L";
                        }
                        else if (comando == 'D' && lado == "O")
                        {
                            lado = "N";
                        }
                        else if (comando == 'D' && lado == "S")
                        {
                            lado = "O";
                        }
                        else if (comando == 'D' && lado == "L")
                        {
                            lado = "S";
                        }
                        #endregion


                    }
                }
                else
                {
                    break;
                }
                
                     Console.WriteLine(lado);
                Console.WriteLine("Tabela de opções");
                Console.WriteLine("Digite 1 para repetir");
                Console.WriteLine("presione enter para sair");
                opcao = Console.ReadLine();
            }

           



        }
    }
}
