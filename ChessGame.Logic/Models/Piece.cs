using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Logic.Models
{
    public class Piece
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public Piece(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public virtual bool IsValidMove(int endRow, int endCol)
        {
            return false;
        }
    }
}
