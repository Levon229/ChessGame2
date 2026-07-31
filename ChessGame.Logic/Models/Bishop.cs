using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Logic.Models
{
    public class Bishop : Piece
    {
        public Bishop(int row, int col) : base(row, col) { }

        public override bool IsValidMove(int endRow, int endCol)
        {
            int rowDiff = System.Math.Abs(endRow - Row);
            int colDiff = System.Math.Abs(endCol - Col);

            return rowDiff == colDiff && rowDiff != 0;
        }
    }
}
