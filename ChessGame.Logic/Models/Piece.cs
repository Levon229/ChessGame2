using ChessGame.Logic.Interfaces;

namespace ChessGame.Logic.Models
{
    public abstract class Piece : IChessPiece
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public Piece(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public virtual bool IsValidMove(int endRow, int endCol)
        {
            return false;
        }
    }
}
