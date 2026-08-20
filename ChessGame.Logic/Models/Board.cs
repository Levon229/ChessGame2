namespace ChessGame.Logic.Models;

public class Board
{
    private char[,] _cells = new char[8, 8];

    public Board()
    {
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
                _cells[i, j] = ((i + j) % 2 == 0) ? '#' : '*';
    }

    public bool IsValid(Coordinate coordinate)
    {
        return coordinate.Row >= 0 && coordinate.Row < 8
            && coordinate.Col >= 0 && coordinate.Col < 8;
    }

    public bool TrySetPiece(Coordinate coordinate, char piece)
    {
        if (!IsValid(coordinate))
            return false;

        _cells[coordinate.Row, coordinate.Col] = piece;
        return true;
    }

    public bool ClearCell(Coordinate coordinate)
    {
        if (!IsValid(coordinate))
            return false;

        _cells[coordinate.Row, coordinate.Col] = ((coordinate.Row + coordinate.Col) % 2 == 0) ? '#' : '*';
        return true;
    }

    public char[,] GetCells() => _cells;
}
