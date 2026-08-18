using ChessGame.Logic.Interfaces;

namespace ChessGame.Logic.Models
{
    public abstract class Piece : IChessPiece
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public Piece(Coordinate coordinate)
        {
            Row = coordinate.Row;
            Col = coordinate.Col;
        }

        public abstract bool IsValidMove(Coordinate coordinate);

    }
}
