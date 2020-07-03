using System;
using Tic_Tac_Toe_Lib;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {

            char[,] board = new char[3, 3];
            char player = 'X';
            Initialize(board);

            do
            {
                Console.Clear();

                Console.Write(" zawarosc tablicy 0,0 " + board[0, 0]);

                Print(board);
                Console.WriteLine();
                Console.Write("Podaj wiersz: ");
                int row = Convert.ToInt32(Console.ReadLine());

                Console.Write("Podaj kolumnę: ");
                int col = Convert.ToInt32(Console.ReadLine());

                
                board[row, col] = player;

                player = Library.ChangePlayer(player);

               
            } while (true);


        }


     



        static void Initialize(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {

                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }

            }
        }

        static void Print(char[,] board)
        {

            Console.WriteLine("   0   1   2 ");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(row+ "| ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col] + " | ");

                }
                Console.WriteLine();
            }
        }

    }
}
