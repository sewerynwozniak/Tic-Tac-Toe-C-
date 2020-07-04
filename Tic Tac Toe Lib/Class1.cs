using System;


 

namespace Tic_Tac_Toe_Lib


{
    public  class Library
    {

        
        public static bool emptySpot;

        public static bool isGoing=true;



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


        public static void checkWinner(char player, char[,] board)
        {
            if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
            {
                isGoing = false;
                Console.WriteLine();
                Console.WriteLine("Gracz " + player + " wygrywa!");
                Console.ReadKey();
            }
            else if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
            {
                isGoing = false;
                Console.WriteLine();
                Console.WriteLine("Gracz " + player + " wygrywa!");
                Console.ReadKey();
            }
            else if (player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
            {
                isGoing = false;
                Console.WriteLine();
                Console.WriteLine("Gracz " + player + " wygrywa!");
                Console.ReadKey();
            }
            else if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])
            {
                isGoing = false;
                Console.WriteLine();
                Console.WriteLine("Gracz " + player + " wygrywa!");
                Console.ReadKey();
            }
            else if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
            {
                isGoing = false;
                Console.WriteLine();
                Console.WriteLine("Gracz " + player + " wygrywa!");
                Console.ReadKey();
            }
            else if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
            {
                isGoing = false;
                Console.WriteLine();
                Console.WriteLine("Gracz " + player + " wygrywa!");
                Console.ReadKey();
            }
            else if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
            {
                isGoing = false;
                Console.WriteLine();
                Console.WriteLine("Gracz " + player + " wygrywa!");
                Console.ReadKey();
            }
            else if (player == board[0, 2] && player == board[1, 1] && player == board[2, 0])
            {
                isGoing = false;
                Console.WriteLine();
                Console.WriteLine("Gracz " + player + " wygrywa!");
                Console.ReadKey();
            }
        }



        public static void checkIfAvail(int row, int col,char[,] board)
        {
           
            if (board[row, col] == 'X' || board[row, col] == 'O')
            {
                emptySpot = false;
                Console.WriteLine("Zajete pole, naciśnij dowolny przycisk i wybierz ponownie");
                Console.ReadKey();

            }
            else
            {
                emptySpot = true;
            }


        }







    }
}
