namespace ChessGame.Logic.Models;

    public class Bishop : Piece
    {
        
        public Bishop(Coordinate coordinate) : base( coordinate) { }

        public override bool IsValidMove(Coordinate coordinate)
        {
            int rowDiff = System.Math.Abs(coordinate.Row - Row);
            int colDiff = System.Math.Abs(coordinate.Col - Col);

            return rowDiff == colDiff && rowDiff != 0;
        }
    }

