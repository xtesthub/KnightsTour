namespace KnightsTour
{
    class Knight
    {
        public int xPosition { get; set; }
        public int yPosition { get; set; }

        public Knight(int xPos = 0, int yPos = 0)
        {
            this.xPosition = xPos;
            this.yPosition = yPos;
        }
    }
}