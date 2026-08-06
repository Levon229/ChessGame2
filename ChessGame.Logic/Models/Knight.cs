namespace ChessGame.Logic.Models
{
    public class Knight : Piece
    {
        public Knight(int row, int col) : base(row, col) { }

        public override bool IsValidMove(int endRow, int endCol)
        {
            int rowDiff = System.Math.Abs(endRow - Row);
            int colDiff = System.Math.Abs(endCol - Col);

            bool isValidShape = (rowDiff == 2 && colDiff == 1) || (rowDiff == 1 && colDiff == 2);

            return isValidShape;
        }
    }
}