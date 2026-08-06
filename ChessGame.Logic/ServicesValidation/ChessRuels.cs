namespace ChessGame.Logic.Services
{
    public static class ChessRules
    {
        private static readonly List<char> AllowedPieces = new List<char> {  'K', 'B', 'R', 'Q', 'T' };

        public static bool IsValidPiece(char piece)
        {
            foreach (var allowed in AllowedPieces)
            {
                if (allowed == piece)
                    return true;
            }
            return false;
        }
    }
}
