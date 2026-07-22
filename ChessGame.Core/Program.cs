using ChessGame.Logic.Models;
using ChessGame.Logic.Services;
using System;

class Program
{

    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
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
                Console.WriteLine("Sxal kordinat (MUTQAGREL NORIC)!");
                Console.ReadKey(); continue;
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Mutqagreq figur (P, K, B, R, Q, T): ");

            string pieceInput = Console.ReadLine();

            if (string.IsNullOrEmpty(pieceInput))
            {
                continue;
            }

            char piece = char.ToUpper(pieceInput[0]);


            if (!ChessRules.IsValidPiece(piece))
            {
                Console.WriteLine("Sxal qar eq yntrel! (SKSEQ NORIC)");
                Console.ReadKey();
                continue;
            }


            board.TrySetPiece(row, col, piece);
        }
    }
}

