namespace KnightsTour
{
    class Chessboard
    {
        public const int FIELD_SIZE = 6;
        public int boardsize { get; set; }
        public int[,] chessboard { get; set; }

        public Chessboard()
        {
            this.boardsize = FIELD_SIZE;
            this.chessboard = new int[boardsize, boardsize];
        }
    }
}