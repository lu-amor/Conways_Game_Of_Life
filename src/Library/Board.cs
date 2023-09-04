using System;

namespace PII_Game_Of_Life
{
    public class Board
    {
        private bool[,] Boards;
        public Board(bool [,] boards)
        {
            this.Boards = boards;
        }

        public void SetBoard(bool[,] boards)
        {
            this.Boards = boards;
        }

        public bool[,] GetBoard()
        {
            return this.Boards;
        }
    }

}
