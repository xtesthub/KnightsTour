namespace KnightsTour
{
    class Player
    {
        public Player()
        {
            //Stuff
        }

        public static void MoveKnight(Knight knight, int move)
        {
            // Countermoves: [1;5], [2;6], [3;7], [4;8]
            if (move == 1)
            {
                knight.xPosition -= 1;
                knight.yPosition -= 2;
            }
            if (move == 2)
            {
                knight.xPosition += 1;
                knight.yPosition -= 2;
            }
            if (move == 3)
            {
                knight.xPosition += 2;
                knight.yPosition -= 1;
            }
            if (move == 4)
            {
                knight.xPosition += 2;
                knight.yPosition += 1;
            }
            if (move == 5)
            {
                knight.xPosition += 1;
                knight.yPosition += 2;
            }
            if (move == 6)
            {
                knight.xPosition -= 1;
                knight.yPosition += 2;
            }
            if (move == 7)
            {
                knight.xPosition -= 2;
                knight.yPosition += 1;
            }
            if (move == 8)
            {
                knight.xPosition -= 2;
                knight.yPosition -= 1;
            }
        }
        public static void ReverseMove(Knight knight, int move)
        {
            if (move < 5)
            {
                move += 4;
            }
            else
            {
                move -= 4;
            }
            MoveKnight(knight, move);
        }
    }
}