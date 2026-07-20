using System;
using System.Collections.Generic;
using System.Text;



namespace ChessGame.Logic.Services
{
    public class BoardPrinter
    {
        public static void Print(char[,] cells)
        {
            string columns = "ABCDEFGH";
            Console.WriteLine("  " + string.Join(" ", columns.ToCharArray()));

            for (int i = 0; i < 8; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(cells[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
