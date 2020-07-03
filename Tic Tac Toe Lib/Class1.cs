using System;

namespace Tic_Tac_Toe_Lib
{
    public class Library
    {

        public static char ChangePlayer(char currPlayer)
        {
            if (currPlayer == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }




        public static bool checkIfAvail(char[,] board, bool going)
        {
            if (board[row, col] == 'X' || board[row, col] == 'O')
            {
                Console.WriteLine("Zajete pole");
                Console.ReadKey();
                going = false;
            }

            return going
        }


    }
}
