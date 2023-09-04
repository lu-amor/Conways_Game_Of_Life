using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using PII_Game_Of_Life;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "..\Library\board.txt";
            ReadFile readFile = new ReadFile(url);
            Board board = new Board(readFile.LoadBoard());
            int lines = readFile.GetLines();
            PrintBoard printer = new PrintBoard(board, lines, lines);
            printer.Printer();
        }
    }
}
