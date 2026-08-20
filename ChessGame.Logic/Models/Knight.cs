namespace ChessGame.Logic.Models;

public class Knight : Piece
{
    public Knight(Coordinate coordinate) : base(coordinate) { }

    public override bool IsValidMove(Coordinate coordinate)
    {
        int rowDiff = Math.Abs(coordinate.Row - Row);
        int colDiff = Math.Abs(coordinate.Col - Col);

        bool isValidShape = (rowDiff == 2 && colDiff == 1) || (rowDiff == 1 && colDiff == 2);

        return isValidShape;
    }
}
