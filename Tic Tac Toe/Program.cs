using System;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using Tic_Tac_Toe_Lib;

namespace Tic_Tac_Toe
{
    public class Program
    {

        

        public static void Main(string[] args)
        {
          int row;
          int col;
          

        char[,] board = new char[3, 3];
            char player = 'X';
            
            Initialize(board);



     

            while(Library.isGoing)
            {
                Console.Clear();
                

                Print(board);

                Console.WriteLine();
                Console.WriteLine("Gracz: "+ player);
                Console.Write("Podaj wiersz: ");
                row = Convert.ToInt32(Console.ReadLine());
               
                while (row != 0 && row != 1 && row != 2)
                {
                    Console.WriteLine("Możesz wybrać tylko cyfry 0, 1 i 2");
                    row = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Podaj kolumnę: ");
                col = Convert.ToInt32(Console.ReadLine());

                while (col != 0 && col != 1 && col != 2)
                {
                    Console.WriteLine("Możesz wybrać tylko cyfry 0, 1 i 2");
                    col = Convert.ToInt32(Console.ReadLine());
                }


                Library.checkIfAvail(row, col,board);

                if (Library.emptySpot)
                {
                    board[row, col] = player;

                    Library.checkWinner(player, board);

                    player = Library.ChangePlayer(player);
                }


                
                

               
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
