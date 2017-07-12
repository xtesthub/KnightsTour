using System;

namespace KnightsTour
{
    class Program
    {
        public static void ShowBoard(Chessboard board)
        {
            for (int i = 0; i < board.boardsize; i++)
            {
                for (int j = 0; j < board.boardsize; j++)
                {
                    Console.Write("  {0}", board.chessboard[i,j].ToString("00"));
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Chessboard boardOne = new Chessboard();
            Knight knightOne = new Knight();

            boardOne.chessboard[knightOne.xPosition, knightOne.yPosition] = 0;  //initialise Knight Starting Position
            if (Solution.FindSolution(boardOne, knightOne, 0))
            {
                ShowBoard(boardOne);
            }
            else
            {
                Console.WriteLine("Keine Lösung gefunden.");
            }
            Console.ReadLine();
        }
    }
}