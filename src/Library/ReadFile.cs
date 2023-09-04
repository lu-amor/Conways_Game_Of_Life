using System;
using System.IO;
namespace PII_Game_Of_Life
{
    public class ReadFile
    {
        private string Url;
        private int Lines = 0;

        public ReadFile(string url)
        {
            this.Url = url;
        }
        // string url = "..\..\assets\board.txt";

        public void SetUrl(string url)
        {
            this.Url = url;
        }
        public string GetUrl()
        {
            return this.Url;
        }
        public int GetLines()
        {
            return this.Lines;
        }

        public bool[,] LoadBoard()
        {
            string content = File.ReadAllText(Url);
            string[] contentLines = content.Split('\n');
            this.Lines = contentLines.Length;

            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            for (int  y=0; y<contentLines.Length;y++)
            {
                for (int x=0; x<contentLines[y].Length; x++)
                {
                    if(contentLines[y][x]=='1')
                    {
                        board[x,y]=true;
                    }
                }
            }
        return board;
        }
    }
}
