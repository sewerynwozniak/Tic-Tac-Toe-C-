using System;
using System.Runtime.InteropServices.ComTypes;
using Tic_Tac_Toe_Lib;

namespace Tic_Tac_Toe
{
    class Program
    {
        public static int row;
        public static int col;
        public static bool going =true;

       public static void Main(string[] args)
        {
            
            char[,] board = new char[3, 3];
            char player = 'X';
            Initialize(board);
            

            do
            {
                Console.Clear();
                

                Print(board);

              

                Console.WriteLine();
                Console.Write("Podaj wiersz: ");
                row = Convert.ToInt32(Console.ReadLine());

                Console.Write("Podaj kolumnę: ");
                col = Convert.ToInt32(Console.ReadLine());



                checkIfAvail(board);

                if (going)
                {
                    board[row, col] = player;

                    player = Library.ChangePlayer(player);
                }

                

               
            } while (true);


        }



        public static void checkIfAvail(char[,] board)
        {
            Console.WriteLine(row);
            Console.WriteLine(col);
            Console.WriteLine(going);
            Console.ReadKey();
            if (board[row, col] == 'X' || board[row, col] == 'O')
            {
                Console.WriteLine("Zajete pole, naciśnij dowolny przycisk i wybierz ponownie");
                Console.ReadKey();
                going = false;
            }
            else
            {
                going = true;
            }


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
