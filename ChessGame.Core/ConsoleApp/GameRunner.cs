using ChessGame.Logic;
using ChessGame.Logic.Interfaces;
using ChessGame.Logic.Models;
using ChessGame.Logic.Services;

namespace ChessGame.Core.ConsoleApp;

public static class GameRunner
{
    public static void Start()
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
            Console.Write("Mutqagreq figur ( K, B, R, Q, T): ");
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

            // dzin uni hatuk qaylelu hnaravorutyun
            if (piece == 'T')
            {
                Console.Write("Dziu skzbnakan kordinat (orinak h7): ");
                string knightStartInput = Console.ReadLine();

                if (!Coordinate.TryParse(knightStartInput, out Coordinate knightStart))
                {
                    Console.WriteLine("Sxal kordinat!");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Dziu verjnakan kordinat (orinak e4): ");
                string knightTargetInput = Console.ReadLine();

                if (!Coordinate.TryParse(knightTargetInput, out Coordinate knightTarget))
                {
                    Console.WriteLine("Sxal kordinat!");
                    Console.ReadKey();
                    continue;
                }

                List<Coordinate> path = KnightPathFinder.FindShortestPath(knightStart, knightTarget);

                Console.WriteLine($"Amena karch ughin {knightStartInput}-ic {knightTargetInput}: {path.Count - 1} qayl");
                Console.Write("Ughin: ");
                foreach (Coordinate step in path)
                {
                    Console.Write($"{step.ToChessNotation()} ");
                }
                Console.WriteLine();
                Console.WriteLine(" Seghmel -> ENTER <- kochaky noric skselu hamar:) ");
                Console.ReadKey();
                continue;
            }

            board.TrySetPiece(coord, piece);
            IChessPiece pieceObj = PieceFactory.Create(piece, coord);

            Console.Clear();
            BoardPrinter.Print(board.GetCells());

            Console.Write($"\n{piece} qary drvec {input}. Mutqagreq nor kordinat, (orinak h1): ");
            string moveInput = Console.ReadLine();

            if (!Coordinate.TryParse(moveInput, out Coordinate moveCoord))
            {
                Console.WriteLine("Sxal kordinat!");
                Console.WriteLine(" Seghmel -> ENTER <- kochaky noric skselu hamar:) ");
                Console.ReadKey();
                continue;
            }

            if (pieceObj.IsValidMove(moveCoord))
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