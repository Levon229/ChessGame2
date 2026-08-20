namespace ChessGame.Logic.Models;

public class Queen : Piece
{
    public Queen(Coordinate coordinate) : base(coordinate) { }

    public override bool IsValidMove(Coordinate coordinate)
    {
        bool sameRow = Row == coordinate.Row;
        bool sameCol = Col == coordinate.Col;
        bool diagonal = System.Math.Abs(coordinate.Row - Row) == System.Math.Abs(coordinate.Col - Col);
        bool actuallyMoved = Row != coordinate.Row || Col != coordinate.Col;

        return (sameRow || sameCol || diagonal) && actuallyMoved;

        ;
    }
}

