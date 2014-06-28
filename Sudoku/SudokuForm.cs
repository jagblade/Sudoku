using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class SudokuMainForm : Form
    {
        int indexToEnter;
        int numberToEnter;
        bool isGameExists;
        int hintsCounter;
        int checksCounter;
        Button[] buttons = new Button[81];
        SudokuSquare[] cells = new SudokuSquare[81];
        SudokuBoard board;
        List<string> listOfSudokus = new List<string>();


        public SudokuMainForm()
        {

            InitializeComponent();

            int posX = 0;
            int posY = 0;
            int sizeW = 35;
            int sizeH = 35;
            int btnTag = 0;
            int pnlX = 0;
            int pnlY = 0;


            HintsPnl.Controls.Add(HintBtn);
            HintsPnl.Controls.Add(HintsLbl);
            HintsPnl.Controls.Add(HintCountLbl);
            HintsPnl.Controls.Add(ErrorCheckBtn);
            HintsPnl.Controls.Add(ChecksLbl);
            HintsPnl.Controls.Add(ChecksCountLbl);


            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Font = new Font(btn.Font.FontFamily, 14, btn.Font.Style | FontStyle.Bold);
                    btn.ForeColor = Color.Blue;
                    btn.Height = sizeH;
                    btn.Width = sizeW;
                    btn.Location = new Point(posX, posY);
                    posX += 40;
                    btn.Tag = btnTag;
                    buttons[btnTag] = btn;
                    btnTag++;
                    SudokuPnl.Controls.Add(btn);
                    btn.Click += btn_Click;
                }
                posY += 40;
                posX = 0;
            }



            int btnCount = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Button PnlBtn = new Button();
                    PnlBtn.Font = new Font(PnlBtn.Font.FontFamily, 14, PnlBtn.Font.Style | FontStyle.Bold);
                    PnlBtn.ForeColor = Color.Blue;
                    PnlBtn.Height = 35;
                    PnlBtn.Width = 35;
                    PnlBtn.Location = new Point(pnlX, pnlY);
                    pnlX += 40;
                    btnCount++;
                    PnlBtn.Text = btnCount.ToString();
                    PnlBtn.Tag = btnCount;
                    ButtonsPnl.Controls.Add(PnlBtn);
                    PnlBtn.Click += PnlBtn_Click;
                }
                pnlX = 0;
                pnlY += 40;
            }

            SudokuPnl.Hide();
            ButtonsPnl.Hide();
            HintsPnl.Hide();
            FinishBtn.Hide();
            SaveBtn.Hide();
        }

        private void CreateNewGame()
        {
            if (!isGameExists)
            {
                for (int i = 0; i < 81; i++)
                {
                    cells[i] = new SudokuSquare();
                    int sudokuDigit = Int32.Parse(sudokuNumbersString[i].ToString());
                    if (sudokuDigit != 0)
                    {
                        cells[i].Number = sudokuDigit;
                        cells[i].IsFilled = true;
                        cells[i].IsAccessGranted = false;
                        buttons[i].Text = sudokuNumbersString[i].ToString();
                        buttons[i].Enabled = false;

                    }
                    else
                    {
                        buttons[i].Text = null;
                        buttons[i].Enabled = true;

                    }
                }

                //entering the correct numbers
                int j = 0;
                for (int i = 82; i < 163; i++)
                {
                    cells[j].CorrectNumber = Int32.Parse(sudokuNumbersString[i].ToString());
                    j++;
                }
            }
            board = new SudokuBoard(cells);
            SudokuPnl.Show();
            HintsPnl.Show();
            SaveBtn.Show();
            FinishBtn.Show();
        }

        void PnlBtn_Click(object sender, EventArgs e)
        {
            numberToEnter = (int)((Button)sender).Tag;
            ButtonsPnl.Hide();

            board.EnterDigit(numberToEnter, indexToEnter);
            buttons[indexToEnter].ForeColor = Color.Blue;
            buttons[indexToEnter].Text = numberToEnter.ToString();

        }


        void btn_Click(object sender, EventArgs e)
        {
            ButtonsPnl.Show();
            indexToEnter = (int)((Button)sender).Tag;
        }


        string sudokuNumbersString;
        Random rnd = new Random();



        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            hintsCounter = 3;
            checksCounter = 3;
            isGameExists = false;
            sudokuNumbersString = null;
            HintCountLbl.Text = hintsCounter.ToString();
            ChecksCountLbl.Text = checksCounter.ToString();
            ButtonsPnl.Hide();

            FileStream fileToRead = new FileStream("SudokuExamples.txt", FileMode.Open);
            using (Stream file = fileToRead)
            {
                TextReader someTextReader = new StreamReader(file);
                string tempString;

                do
                {
                    tempString = someTextReader.ReadLine();
                    if (tempString != null)
                    {
                        listOfSudokus.Add(tempString);
                    }

                } while (tempString != null);

            }

            int tempRandomNumber = rnd.Next(listOfSudokus.Count);
            sudokuNumbersString = listOfSudokus[tempRandomNumber];

            if (sudokuNumbersString != null)
            {
                CreateNewGame();
            }
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            if (board.CheckIsSolved())
            {
                MessageBox.Show("Congratulations!!");
                SudokuPnl.Hide();
                HintsPnl.Hide();
                SaveBtn.Hide();
                FinishBtn.Hide();
            }
            else
            {
                MessageBox.Show("The Sudoku is wrong!");
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDialog = new SaveFileDialog();
            SaveDialog.Filter = " Sudoku Text File | *.stf";



            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream fileToSave = SaveDialog.OpenFile())
                {
                    DataHolder someDataHolder = new DataHolder();
                    someDataHolder.CellsHolder = cells;
                    someDataHolder.NumberOfHints = hintsCounter;
                    someDataHolder.NumberOfChecks = checksCounter;

                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileToSave, someDataHolder);
                }
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            isGameExists = true;
            ButtonsPnl.Hide();

            OpenFileDialog LoadDialog = new OpenFileDialog();
            LoadDialog.Filter = "Sudoku Text File | *.stf";

            if (LoadDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataHolder someDataHolder = null;
                    using (Stream fileToLoad = LoadDialog.OpenFile())
                    {
                        if (LoadDialog.FileName.ToLower().EndsWith(".stf"))
                        {
                            BinaryFormatter formatter = new BinaryFormatter();
                            someDataHolder = (DataHolder)formatter.Deserialize(fileToLoad);
                        }
                        else
                        {
                            throw new InvalidOperationException("Unknown file type");
                        }
                    }

                    cells = someDataHolder.CellsHolder;
                    hintsCounter = someDataHolder.NumberOfHints;
                    checksCounter = someDataHolder.NumberOfChecks;
                    HintCountLbl.Text = hintsCounter.ToString();
                    ChecksCountLbl.Text = checksCounter.ToString();



                    for (int i = 0; i < 81; i++)
                    {
                        buttons[i].Text = null;
                        if (cells[i].IsFilled)
                        {
                            buttons[i].Text = cells[i].Number.ToString();
                        }

                        buttons[i].Enabled = cells[i].IsAccessGranted;

                    }

                    CreateNewGame();
                }
                catch (Exception)
                {
                    MessageBox.Show("Unknown file type");
                }
            }
        }



        private void HintBtn_Click(object sender, EventArgs e)
        {
            bool isEverythingFilled = true;

            for (int i = 0; i < 81; i++)
            {
                if (!cells[i].IsFilled)
                {
                    isEverythingFilled = false;
                    break;
                }
            }

                if (hintsCounter != 0 && !isEverythingFilled)
                {
                    int rndHintFinder;
                    do
                    {
                        rndHintFinder = rnd.Next(81);
                        if (!cells[rndHintFinder].IsFilled)
                        {
                            cells[rndHintFinder].Number = cells[rndHintFinder].CorrectNumber;
                            cells[rndHintFinder].IsAccessGranted = false;
                            buttons[rndHintFinder].Text = cells[rndHintFinder].Number.ToString();
                            buttons[rndHintFinder].Enabled = false;
                        }
                    }
                    while (cells[rndHintFinder].IsFilled);

                    cells[rndHintFinder].IsFilled = true;
                    hintsCounter--;
                    HintCountLbl.Text = hintsCounter.ToString();
                }
                else if(isEverythingFilled == true)
                {
                    MessageBox.Show("Your board is filled!!");
                }
                else
                {
                    MessageBox.Show("You are out of hints!!");
                }
        }

        private void ErrorCheckBtn_Click(object sender, EventArgs e)
        {
            if (checksCounter != 0)
            {

                for (int i = 0; i < 81; i++)
                {
                    if (cells[i].IsAccessGranted && cells[i].IsFilled)
                    {
                        if (cells[i].Number != cells[i].CorrectNumber)
                        {
                            buttons[i].ForeColor = Color.Red;
                        }
                    }
                }


                checksCounter--;
                ChecksCountLbl.Text = checksCounter.ToString();
            }
            else
            {
                MessageBox.Show("You are out of checks !!");
            }
        }
    }
}
