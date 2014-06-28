using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    [Serializable]
    public class DataHolder
    {
        public SudokuSquare[] CellsHolder { get; set; }
        public int NumberOfHints { get; set; }
        public int NumberOfChecks { get; set; }
    }
}
