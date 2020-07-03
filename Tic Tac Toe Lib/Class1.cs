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

    }
}
