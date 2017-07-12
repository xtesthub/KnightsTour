namespace KnightsTour
{
    class Solution
    {
        public static int index = 0;
        public static int path = 0;

        public static bool CheckWheatherFieldHasAlreadyBeenVisited(Chessboard board, Knight knight)
        {
            return board.chessboard[knight.xPosition, knight.yPosition] != 0 ? true : false;
        }

        public static bool CheckIfMoveIsLegal(Chessboard board, Knight knight, int move)
        {
            Player.MoveKnight(knight, move);
            if (knight.xPosition < 0 || knight.yPosition < 0 || knight.xPosition >= Chessboard.FIELD_SIZE || knight.yPosition >= Chessboard.FIELD_SIZE)
            {
                Player.ReverseMove(knight, move);
                return false;
            }
            if (CheckWheatherFieldHasAlreadyBeenVisited(board, knight))
            {
                Player.ReverseMove(knight, move);
                return false;
            }
            Player.ReverseMove(knight, move);
            return true;
        }

        public static bool FindSolution(Chessboard board, Knight knight, int index)
        {
            if (board.chessboard[knight.xPosition, knight.yPosition] != 0)
            {
                return false;
            }
            board.chessboard[knight.xPosition, knight.yPosition] = path++;
            if (index == Chessboard.FIELD_SIZE * Chessboard.FIELD_SIZE - 1)
            {
                return true;
            }
            for (int move = 1; move <= 8; move++)
            {
                if (CheckIfMoveIsLegal(board, knight, move))
                {
                    Player.MoveKnight(knight, move);
                    if (FindSolution(board, knight, index + 1))
                    {
                        return true;
                    }
                    Player.ReverseMove(knight, move);
                }
            }
            board.chessboard[knight.xPosition, knight.yPosition] = 0;
            path--;
            return false;
        }
    }
}