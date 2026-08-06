using ChessGame.Logic.Interfaces;
using ChessGame.Logic.Models;
using System.Net.NetworkInformation;



namespace ChessGame.Logic.Services
{
    public static class PieceFactory
    {
        public static IChessPiece Create(char pieceChar, int row, int col)
        {
            switch (char.ToUpper(pieceChar))
            {
                case 'B':
                    return new Bishop(row, col);
                case 'Q':
                    return new Queen(row, col);
                case 'R':
                    return new Rook(row, col);
                case 'T':
                    return new Knight(row, col);  
                    
                case 'K':
                    return new King(row, col);
                default:
                    throw new ArgumentException("Anhayt qari tip: " + pieceChar);
            }
        }
    }
}


