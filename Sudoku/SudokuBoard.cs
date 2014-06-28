using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class SudokuBoard
    {
        private SudokuSquare[] board;

        public SudokuBoard(SudokuSquare[] staticBoard)
        {
            board = staticBoard;
        }


        public void EnterDigit(int number,int index)
        {
            board[index].Number = number;
            board[index].IsFilled = true;
        }

        public bool CheckIsSolved()
        {
            for (int i = 0; i < 81; i++)
            {
                if ((board[i].Number != board[i].CorrectNumber) || !board[i].IsFilled )
                {
                    return false;
                }
            }
            return true;
        }
    }
}
