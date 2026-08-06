
namespace ChessGame.Logic.Models
{
    public class King : Piece
    {
        public King(int row, int col) : base(row, col) { }

        public override bool IsValidMove(int endRow, int endCol)
        {
            int rowDiff = System.Math.Abs(endRow - Row);
            int colDiff = System.Math.Abs(endCol - Col);

            bool withinOneSquare = rowDiff <= 1 && colDiff <= 1;
            bool actuallyMoved = rowDiff != 0 || colDiff != 0;

            return withinOneSquare && actuallyMoved;
        }
    }
}
