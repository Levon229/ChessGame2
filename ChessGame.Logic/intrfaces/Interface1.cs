namespace ChessGame.Logic.Interfaces
{
    public interface IChessPiece
    {
        bool IsValidMove(int endRow, int endCol);
    }
}
