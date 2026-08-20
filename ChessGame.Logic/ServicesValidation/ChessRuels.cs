using System;
using ChessGame.Logic.Models;
using System.Collections.Generic;

namespace ChessGame.Logic.Services;

public static class ChessRules
{
    private static readonly List<char> AllowedPieces = new List<char> { 'K', 'B', 'R', 'Q', 'T' };

    public static bool IsValidPiece(char piece)
    {
        foreach (var allowed in AllowedPieces)
        {
            if (allowed == piece)
                return true;
        }
        return false;
    }

    public static PieceType CharToPieceType(char piece)
    {
        switch (char.ToUpper(piece))
        {
            case 'B':
                return PieceType.Bishop;
            case 'Q':
                return PieceType.Queen;
            case 'R':
                return PieceType.Rook;
            case 'T':
                return PieceType.Knight;
            case 'K':
                return PieceType.King;
            default:
                throw new ArgumentException("Anhayt qari tip: " + piece);
        }
    }
}