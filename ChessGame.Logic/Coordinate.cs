namespace ChessGame.Logic;

public struct Coordinate
{
    public int Row { get; }
    public int Col { get; }

    private Coordinate(int row, int col)
    {
        Row = row;
        Col = col;
    }

    public static Coordinate FromRowCol(int row, int col)
    {
        return new Coordinate(row, col);
    }

    public string ToChessNotation()
    {
        char colChar = (char)('a' + Col);
        int rowNumber = 8 - Row;
        return $"{colChar}{rowNumber}";
    }

    public static bool TryParse(string input, out Coordinate coordinate)
    {
        coordinate = default;

        if (string.IsNullOrEmpty(input) || input.Length != 2)
            return false;

        char colChar = char.ToLower(input[0]);
        char rowChar = input[1];

        if (colChar < 'a' || colChar > 'h' || rowChar < '1' || rowChar > '8')
            return false;

        int col = colChar - 'a';
        int row = 8 - (rowChar - '0');

        coordinate = new Coordinate(row, col);
        return true;
    }
}