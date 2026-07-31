using ChessGame.Logic.Models;
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





    
        public static class ChessRules
        {
            private static readonly List<char> AllowedPieces = new List<char> { 'P', 'K', 'B', 'R', 'Q', 'T' };

            public static bool IsValidPiece(char piece)
            {
                foreach (var allowed in AllowedPieces)
                {
                    if (allowed == piece)
                        return true;
                }
                return false;
            }
        }




    public static class PieceFactory
    {
        public static Piece Create(char pieceChar, int row, int col)
        {
            switch (char.ToUpper(pieceChar))
            {
                case 'B':
                    return new Bishop(row, col);
                case 'Q':
                    return new Queen(row, col);
                default:
                    return new Piece(row, col);
            }
        }
    }
}


