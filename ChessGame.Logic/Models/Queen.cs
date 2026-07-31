using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Logic.Models
{
    public class Queen : Piece
    {
        public Queen(int row, int col) : base(row, col) { }

        public override bool IsValidMove(int endRow, int endCol)
        {   
            bool sameRow = Row == endRow;
            bool sameCol = Col == endCol;
            bool diagonal = System.Math.Abs(endRow - Row) == System.Math.Abs(endCol - Col);
            bool actuallyMoved = Row != endRow || Col != endCol;

            return (sameRow || sameCol || diagonal) && actuallyMoved;
        }
    }
}
