using ChessGame.Logic;
using ChessGame.Logic.Models;
using ChessGame.Logic.Services;
using System;

using ChessGame.Logic;
using ChessGame.Logic.Models;
using ChessGame.Logic.Services;
using System;

using ChessGame.Logic;
using ChessGame.Logic.Models;
using ChessGame.Logic.Services;
using System;

using ChessGame.Logic;
using ChessGame.Logic.Models;
using ChessGame.Logic.Services;
using System;
using System.Threading.Channels;

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

            if (!Coordinate.TryParse(input, out Coordinate coord))
            {
                Console.WriteLine("Sxal kordinat (MUTQAGREL NORIC)!");
                Console.WriteLine(" Seghmel -> ENTER <- kochaky noric skselu hamar:) ");

                Console.ReadKey();
                continue;
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Mutqagreq figur (P, K, B, R, Q, T): ");
            string pieceInput = Console.ReadLine();

            if (string.IsNullOrEmpty(pieceInput))
                continue;

            char piece = char.ToUpper(pieceInput[0]);

            if (!ChessRules.IsValidPiece(piece))
            {
                Console.WriteLine("Sxal qar eq yntrel! (SKSEQ NORIC)");
                Console.WriteLine(" Seghmel -> ENTER <- kochaky noric skselu hamar:) ");
                Console.ReadKey();
                continue;
            }

            board.TrySetPiece(coord, piece);

            Piece pieceObj = PieceFactory.Create(piece, coord.Row, coord.Col);

            Console.Clear();
            BoardPrinter.Print(board.GetCells());

            Console.Write($"\n{piece} qary drvec {input}. Mutqagreq nor kordinat,  (orinak h1): ");
            string moveInput = Console.ReadLine();

            if (!Coordinate.TryParse(moveInput, out Coordinate moveCoord))
            {
                Console.WriteLine("Sxal kordinat!");
                Console.WriteLine(" Seghmel -> ENTER <- kochaky noric skselu hamar:) ");
                Console.ReadKey();
                continue;
            }

            if (pieceObj.IsValidMove(moveCoord.Row, moveCoord.Col))
            {
                board.ClearCell(coord);
                board.TrySetPiece(moveCoord, piece);
                Console.WriteLine($"Qayl {input} -> {moveInput} katarvec!");
            }
            else
            {
                Console.WriteLine($"Qayl {input} -> {moveInput}  SXAL KOD MUTQGREL NORIC!");
                Console.WriteLine(" Seghmel -> ENTER <- kochaky noric skselu hamar:) ");
            }

            Console.ReadKey();
        }
    }
}