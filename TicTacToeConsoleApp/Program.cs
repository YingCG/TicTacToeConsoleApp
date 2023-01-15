using System; 

namespace TicTacToeConsoleApp
{
    class Program
    {
        static int[] board = new int[9];

        static void Main(string[] args)
        {
            Console.WriteLine("Learn array and for loop with Tic Tac Toe!");
            board[0] = 0;
            board[1] = 0;
            board[2] = 0;
            board[3] = 0;
            board[4] = 0;
            board[5] = 0;
            board[6] = 0;
            board[7] = 0;
            board[8] = 0;

            int userTurn = -1;
            int playerZero = -1;
            Random zero= new Random();

            while (checkForWinner() == 0)
            {

                // don't allow the human choose an already occupied square
                while(userTurn == -1 || board[userTurn] != 0)
                {
                    Console.WriteLine("where you want to put your x (position 0 -8)");
                    userTurn = int.Parse(Console.ReadLine());
                    Console.WriteLine("you play at postition" + userTurn);
                }
                board[userTurn] = 1;

                while(playerZero == -1 || board[playerZero] != 0)
                {
                playerZero = zero.Next(0,8);
                Console.WriteLine("Computer play at postition" + playerZero);
                }
                board[playerZero] = 2;


                printBoard();
            }
            Console.WriteLine("player" + checkForWinner() + "won!");
        }

        private static int checkForWinner()
        {
            // return a 0 if nobody won. return the player number if they won

            //top row
            if (board[0] == board[1] && board[1] == board[2])
            {
                // return a winner same as board[1] or board[2]
                return board[0];
            }

            //second row
            if (board[3] == board[4] && board[4] == board[5])
            {
                return board[3];
            }

            //third row
            if (board[6] == board[7] && board[7] == board[8])
            {
                return board[6];
            }

            //first column
            if (board[0] == board[3] && board[3] == board[6])
            {
                return board[0];
            }

            //second column
            if (board[1] == board[4] && board[4] == board[7])
            {
                return board[1];
            }

            //third column
            if (board[2] == board[5] && board[5] == board[8])
            {
                return board[2];
            }


            //first diagonal
            if (board[0] == board[4] && board[4] == board[8])
            {
                return board[0];
            }

            //second diagonal
            if (board[2] == board[4] && board[4] == board[6])
            {
                return board[2];
            }

            return 0;
        }

        private static void printBoard()
        {

            for (int i = 0; i < 9; i++)
            {
                // print the board
                //Console.WriteLine("Square " + i + " contains " + board[i]);

                // print x or o for each square
                if (board[i] == 0)
                {
                    Console.Write(".");
                }
                if (board[i] == 1)
                {
                    Console.Write("X");
                }
                if (board[i] == 2)
                {
                    Console.Write("O");
                }

                // print a new line every 3rd character
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                }

            }
        }
    }
}
