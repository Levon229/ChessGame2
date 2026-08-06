using System;

namespace ChessGame.Core.ConsoleApp
{
    public class BoardPrinter
    {
        public static void Print(char[,] cells)
        {
            ConsoleColor originalBg = Console.BackgroundColor;
            ConsoleColor originalFg = Console.ForegroundColor;

            string columns = "ABCDEFGH";
            Console.WriteLine("  " + string.Join(" ", columns.ToCharArray()));

            for (int i = 0; i < 8; i++)
            {
                Console.Write(8 - i + " ");

                for (int j = 0; j < 8; j++)
                {
                    bool isLightSquare = (i + j) % 2 == 0;
                    Console.BackgroundColor = isLightSquare ? ConsoleColor.White : ConsoleColor.Black;
                    Console.ForegroundColor = isLightSquare ? ConsoleColor.Black : ConsoleColor.White;

                    char symbol = cells[i, j];
                    
                    char displayChar = (symbol == '#' || symbol == '*') ? ' ' : symbol;

                    Console.Write(displayChar + " ");
                }

                Console.BackgroundColor = originalBg;
                Console.ForegroundColor = originalFg;
                Console.WriteLine();
            }

            Console.BackgroundColor = originalBg;
            Console.ForegroundColor = originalFg;
        }
    }
}
