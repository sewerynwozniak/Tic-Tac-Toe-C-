using System;


 

namespace Tic_Tac_Toe_Lib


{
    public  class Library
    {

        
        public static bool going;

      

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



        public static void checkIfAvail(int row, int col,char[,] board)
        {
            Console.WriteLine(row);
            Console.WriteLine(col);

            Console.ReadKey();
            if (board[row, col] == 'X' || board[row, col] == 'O')
            {
                going = false;
                Console.WriteLine("Zajete pole, naciśnij dowolny przycisk i wybierz ponownie");
                Console.WriteLine(going);
                Console.ReadKey();

            }
            else
            {
                going = true;
            }


        }







    }
}
