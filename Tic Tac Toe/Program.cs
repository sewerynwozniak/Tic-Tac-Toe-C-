using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {

            char[,] board = new char[3, 3];
            board[0, 2] = 'X';

            for(int row = 0; row < 3; row++)
            {
                Console.WriteLine();
                for( int col = 0; col < 3; col++)
                {
                    
                    Console.Write(board[row, col]+" | ");
                }
                
            }
        }
    }
}
