
namespace ChessGame.Logic.Models;

    public class King : Piece
    {
        public King(Coordinate coordinate) : base(coordinate) { }

        public override bool IsValidMove(Coordinate coordinate)
        {
            int rowDiff = Math.Abs(coordinate.Row - Row);
            int colDiff = Math.Abs(coordinate.Col - Col);

            bool withinOneSquare = rowDiff <= 1 && colDiff <= 1;
            bool actuallyMoved = rowDiff != 0 || colDiff != 0;

            return withinOneSquare && actuallyMoved;
        }
    }

