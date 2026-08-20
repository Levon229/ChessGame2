namespace ChessGame.Logic.Models;

public class Rook : Piece
{
    public Rook(Coordinate coordinate) : base(coordinate) { }

    public override bool IsValidMove(Coordinate coordinate)
    {
        bool sameRow = Row == coordinate.Row;
        bool sameCol = Col == coordinate.Col;
        bool actuallyMoved = Row != coordinate.Row || Col != coordinate.Col;

        return (sameRow || sameCol) && actuallyMoved;
    }
}
