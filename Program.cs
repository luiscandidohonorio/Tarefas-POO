using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {

            //BOAS VINDAS
            Console.WriteLine("----JOGO DA VELHA----\n" +
                "JOGADOR 1: 'X' " +
                "\t\tJOGADOR 2: 'O' \n");


            //VARIAVEIS E ARRAYS
            int jogada1, jogada2;
            int i = 0;
            String[,] tabuleiro = new String[3, 3];
            bool ganhou;

            //DEFININDO O TABULEIRO
            tabuleiro[0, 0] = "7";
            tabuleiro[0, 1] = "8";
            tabuleiro[0, 2] = "9";

            tabuleiro[1, 0] = "4";
            tabuleiro[1, 1] = "5";
            tabuleiro[1, 2] = "6";

            tabuleiro[2, 0] = "1";
            tabuleiro[2, 1] = "2";
            tabuleiro[2, 2] = "3";

            do
            {
                i++;
                //PRIMEIRA PARTE DO TABULEIRO
                Console.WriteLine(" -------------");

                for (int t = 0; t < 3; t++)
                {
                    Console.Write(" | " + tabuleiro[0, t]);
                }
                Console.Write(" | \n");

                //SEGUNDA PARTE DO TABULEIRO
                for (int t = 0; t < 3; t++)
                {
                    Console.Write(" | " + tabuleiro[1, t]);
                }
                Console.Write(" | \n");

                //TERCEIRA PARTE DO TABULEIRO
                for (int t = 0; t < 3; t++)
                {
                    Console.Write(" | " + tabuleiro[2, t]);
                }
                Console.Write(" | \n");

                Console.WriteLine(" -------------");

                /*---------------------------------------------------------------------------------------*/

                /*-----------------------------------JOGADOR UM----------------------------------------*/
                try
                {
                    Console.Write("vez do Jogador 1: ");
                    jogada1 = int.Parse(Console.ReadLine());


                    //PARTE SUPERIOR DO TABULEIRO - jogador 2 "X".
                    if (jogada1 == 7)
                    {
                        tabuleiro[0, 0] = "X";
                    }
                    else if (jogada1 == 8)
                    {
                        tabuleiro[0, 1] = "X";
                    }
                    else if (jogada1 == 9)
                    {
                        tabuleiro[0, 2] = "X";
                    }

                    //PARTE CENTRAL DO TABULEIRO - jogador 2 "X".
                    else if (jogada1 == 4)
                    {
                        tabuleiro[1, 0] = "X";
                    }
                    else if (jogada1 == 5)
                    {
                        tabuleiro[1, 1] = "X";
                    }
                    else if (jogada1 == 6)
                    {
                        tabuleiro[1, 2] = "X";
                    }

                    //PARTE INFERIO DO TABULEIRO - jogador 2 "X".
                    else if (jogada1 == 1)
                    {
                        tabuleiro[2, 0] = "X";
                    }
                    else if (jogada1 == 2)
                    {
                        tabuleiro[2, 1] = "X";
                    }
                    else if (jogada1 == 3)
                    {
                        tabuleiro[2, 2] = "X";
                    }

                    Console.Clear();

                    //PRIMEIRA PARTE DO TABULEIRO - REAPARECER TABULEIRO
                    Console.WriteLine(" -------------");

                    for (int t = 0; t < 3; t++)
                    {
                        Console.Write(" | " + tabuleiro[0, t]);
                    }
                    Console.Write(" | \n");

                    //SEGUNDA PARTE DO TABULEIRO
                    for (int t = 0; t < 3; t++)
                    {
                        Console.Write(" | " + tabuleiro[1, t]);
                    }
                    Console.Write(" | \n");

                    //TERCEIRA PARTE DO TABULEIRO
                    for (int t = 0; t < 3; t++)
                    {
                        Console.Write(" | " + tabuleiro[2, t]);
                    }
                    Console.Write(" | \n");

                    Console.WriteLine(" -------------");


                    //POSSIBILIDADES DE GANHAR X - HORIZONTAL
                    if ((tabuleiro[0, 0] == "X") && (tabuleiro[0, 1] == "X") && (tabuleiro[0, 2] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("Jogador 1 Ganhou!");
                        break;
                    }
                    else if ((tabuleiro[1, 0] == "X") && (tabuleiro[1, 1] == "X") && (tabuleiro[1, 2] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("Jogador 1 Ganhou!");
                        break;
                    }
                    else if ((tabuleiro[2, 0] == "X") && (tabuleiro[2, 1] == "X") && (tabuleiro[2, 2] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("Jogador 1 Ganhou!");
                        break;
                    }

                    //POSSIBLIDADES DE GANHAR X - VERTICAL
                    if ((tabuleiro[0, 0] == "X") && (tabuleiro[1, 0] == "X") && (tabuleiro[2, 0] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("Jogador 1 Ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 1] == "X") && (tabuleiro[1, 1] == "X") && (tabuleiro[2, 1] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("Jogador 1 Ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 2] == "X") && (tabuleiro[1, 2] == "X") && (tabuleiro[2, 2] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("Jogador 1 Ganhou!");
                        break;
                    }

                    //POSSIBLIDADES DE GANHAR X - DIAGONAL
                    if ((tabuleiro[0, 0] == "X") && (tabuleiro[1, 1] == "X") && (tabuleiro[2, 2] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("Jogador 1 Ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 2] == "X") && (tabuleiro[1, 1] == "X") && (tabuleiro[2, 0] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("Jogador 1 Ganhou!");
                        break;
                    }


                    /*--------------------------------------------------------------------------------------*/

                    /*-----------------------------------JOGADOR DOIS----------------------------------------*/

                    Console.Write("vez do Jogador 2: ");
                    jogada2 = int.Parse(Console.ReadLine());

                    //PARTE SUPERIOR DO TABULEIR - jogador 2 "O".
                    if (jogada2 == 7)
                    {
                        tabuleiro[0, 0] = "O";
                    }
                    else if (jogada2 == 8)
                    {
                        tabuleiro[0, 1] = "O";
                    }
                    else if (jogada2 == 9)
                    {
                        tabuleiro[0, 2] = "O";
                    }

                    //PARTE CENTRAL DO TABULEIRO - jogador 2 "O".
                    else if (jogada2 == 4)
                    {
                        tabuleiro[1, 0] = "O";
                    }
                    else if (jogada2 == 5)
                    {
                        tabuleiro[1, 1] = "O";
                    }
                    else if (jogada2 == 6)
                    {
                        tabuleiro[1, 2] = "O";
                    }

                    //PARTE INFERIO DO TABULEIRO - jogador 2 "O".
                    else if (jogada2 == 1)
                    {
                        tabuleiro[2, 0] = "O";
                    }
                    else if (jogada2 == 2)
                    {
                        tabuleiro[2, 1] = "O";
                    }
                    else if (jogada2 == 3)
                    {
                        tabuleiro[2, 2] = "O";
                    }


                    //POSSIBILIDADES DE GANHAR O - HORIZONTAL
                    if ((tabuleiro[0, 0] == "O") && (tabuleiro[0, 1] == "O") && (tabuleiro[0, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("Jogador 2 Ganhou!");
                        break;
                    }
                    else if ((tabuleiro[1, 0] == "O") && (tabuleiro[1, 1] == "O") && (tabuleiro[1, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("Jogador 2 Ganhou!");
                        break;
                    }
                    else if ((tabuleiro[2, 0] == "O") && (tabuleiro[2, 1] == "O") && (tabuleiro[2, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("Jogador 2 Ganhou!");
                        break;
                    }

                    //POSSIBLIDADES DE GANHAR O - VERTICAL
                    if ((tabuleiro[0, 0] == "O") && (tabuleiro[1, 0] == "O") && (tabuleiro[2, 0] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("Jogador 2 Ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 1] == "O") && (tabuleiro[1, 1] == "O") && (tabuleiro[2, 1] == "OX"))
                    {
                        ganhou = false;
                        Console.WriteLine("Jogador 2 Ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 2] == "O") && (tabuleiro[1, 2] == "O") && (tabuleiro[2, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("Jogador 2 Ganhou!");
                        break;
                    }

                    //POSSIBLIDADES DE GANHAR O - DIAGONAL
                    if ((tabuleiro[0, 0] == "O") && (tabuleiro[1, 1] == "O") && (tabuleiro[2, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("Jogador 2 Ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 2] == "O") && (tabuleiro[1, 1] == "O") && (tabuleiro[2, 0] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("Jogador 2 Ganhou!");
                        break;
                    }

                    Console.Clear();

                }
                catch (Exception)
                {
                    Console.WriteLine("Apenas numeros, que contem no tabuleiro!");
                }

            } while (ganhou = true || i == 9);


            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();


        }
    }
}