using System;

namespace TicTacToeNS2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            char[,] startBoard =
            {
                {'1','2','3' },
                {'4','5','6' },
                {'7','8','9' },
            };
            char[,] gameBoard = startBoard.Clone() as char[,];

            //Flags
            bool player1Won = false;
            bool player2Won = false;
            bool nextIsPlayer1 = true; // true = player 1 move, false = plaery 2 move

            ////////////////////////
            
            //Loop over rounds
            for (int round = 0; round < gameBoard.Length; round++)
            {
                Console.Clear();
                //todo: draw the board

                if (nextIsPlayer1)
                {
                    //todo: player 1 move
                    nextIsPlayer1 = true;
                }
                if (player1Won || player2Won)
                    break;
            }
            ///////////////////////////
            ///end the game
            Console.Clear();
            Console.WriteLine("game ended");


        }
    }
}
