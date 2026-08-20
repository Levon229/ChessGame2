using ChessGame.Logic.Interfaces;
using ChessGame.Logic.Models;

namespace ChessGame.Logic.Services;

public static class PieceFactory
{
    public static IChessPiece Create(char pieceChar, Coordinate coordinate)
    {
        PieceType type = ChessRules.CharToPieceType(pieceChar);

        switch (type)
        {
            case PieceType.Bishop:
                return new Bishop(coordinate);
            case PieceType.Queen:
                return new Queen(coordinate);
            case PieceType.Rook:
                return new Rook(coordinate);
            case PieceType.Knight:
                return new Knight(coordinate);
            case PieceType.King:
                return new King(coordinate);
            default:
                throw new ArgumentException("Anhayt PieceType: " + type);
        }
    }
}



