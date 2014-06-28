using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    [Serializable]
    public class SudokuSquare
    {
        public int Number { get; set; }
        public int CorrectNumber { get; set; }
        public bool IsFilled { get; set; }

        private bool isAccessGranted = true;
        public bool IsAccessGranted
        {
            get { return isAccessGranted; }
            set { isAccessGranted = value; }
        }
    }
}
