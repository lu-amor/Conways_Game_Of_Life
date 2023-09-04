using System;
using System.Text;
using PII_Game_Of_Life;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class PrintBoard
    {
        private Board Board;
        private int Width;
        private int Height;
        public PrintBoard(Board board, int width, int height)
        {
            this.Board = board;
            this.Width = width;
            this.Height = height;
        }
        public void Printer()
        {
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<Height;y++)
                {
                    for (int x = 0; x<Width; x++)
                    {
                        if(Board.GetBoard()[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                Board.SetBoard(new Rules(Board.GetBoard()).Conditions());
                Thread.Sleep(300);
            }
        }

        public void SetWidth(int width)
        {
            this.Width = width;
        }
        public void SetHeight(int height)
        {
            this.Height = height;
        }
        public int GetWidth()
        {
            return this.Width;
        }
        public int GetHeight()
        {
            return this.Height;
        }
    }
}
