using System;
using System.Collections.Generic;
using System.Text;


namespace ChessGame.Logic.Models
{
    public class Board
    {
        private char[,] _cells = new char[8, 8];

        public Board()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    _cells[i, j] = ((i + j) % 2 == 0) ? '#' : '*';
        }


        public bool IsValid(int row, int col)
        {
            return row >= 0 && row < 8 && col >= 0 && col < 8;
        }

        
        public bool TrySetPiece(int row, int col, char piece)
        {
            if (!IsValid(row, col)) 
            {
                return false; 
            }

            _cells[row, col] = piece; 
            return true;
        }

        public char[,] GetCells() => _cells;
    }


}