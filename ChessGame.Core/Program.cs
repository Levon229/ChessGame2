using ChessGame.Logic.Models;
using ChessGame.Logic.Services;
using System;

class Program
{

    static void Main()
    {
        Board board = new Board();

        while (true)
        {
            Console.Clear();
            BoardPrinter.Print(board.GetCells());

            Console.Write("\nMutqagreq kordinat (orinak h7): ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || input.Length < 2) continue;

            int col = input[0] - 'a';
            int row = 8 - (input[1] - '0');

            if (!board.IsValid(row, col))
            {
                Console.WriteLine("Sxal kordinat!");
                Console.ReadKey();
            }

            Console.Write("Mutqagreq figur (P, K, B, R, Q, T): ");
            char piece = Console.ReadLine().ToUpper()[0];

            board.TrySetPiece(row, col, piece); 
        }
    }
}

