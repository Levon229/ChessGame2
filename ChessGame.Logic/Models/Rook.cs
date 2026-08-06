namespace ChessGame.Logic.Models
{
    public class Rook : Piece
    {
        public Rook(int row, int col) : base(row, col) { }

        public override bool IsValidMove(int endRow, int endCol)
        {
            bool sameRow = Row == endRow;
            bool sameCol = Col == endCol;
            bool actuallyMoved = Row != endRow || Col != endCol;

            return (sameRow || sameCol) && actuallyMoved;
        }
    }
}