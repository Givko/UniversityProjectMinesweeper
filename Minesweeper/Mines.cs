using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Minesweeper
{
    public class Mines
    {
        //Initialize Playboard object
        private sbyte[,] playBoardMatrix;
        private Playboard playBoard = new Playboard();
        public Mines()
        {

        }
        //On FormLoad generate randomlly the mines onto the playBoard
        public void Generate(sbyte mines, sbyte rows, sbyte cols)
        {
            sbyte[,] matrix = new sbyte[rows, cols];
            Random generateBomb = new Random();

            //Iterate through the Play Board until all mines are positioned(when mines = 0)
            while (mines > 0)
            {
                for (int row = 1; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 1; col < matrix.GetLength(1) - 1; col++)
                    {
                        //If the current cell has a mine skip it
                        if (matrix[row, col] != 1 && generateBomb.Next(0, 6) == 1)
                        {
                            matrix[row, col] = 1;
                            mines--;
                            if (mines == 0)
                            {
                                break;
                            }
                        }
                    }
                    if (mines == 0)
                    {
                        break;
                    }
                }
            }
            playBoardMatrix = matrix;
        }
        public void CheckForMines(Button clickedButton, Button[,] buttons)
        {
            sbyte[] rowCol = clickedButton.Name.ToString().Split(new string[] { "btnR", "C" }, StringSplitOptions.RemoveEmptyEntries).Select(sbyte.Parse).ToArray();
            sbyte curRow = rowCol[0];
            sbyte curCol = rowCol[1];
            sbyte minesAround = 0;

            //Check if the current cell is outside of the playboard
            if (curRow < 0 || curCol < 0 || curRow == playBoardMatrix.GetLength(0) || curCol == playBoardMatrix.GetLength(1))
            {
                return;
            }
            if (playBoardMatrix[curRow, curCol] == 1)
            {
                playBoard.ClickBombs(buttons, playBoardMatrix);
                DialogResult tryAgain = MessageBox.Show("You clicked a Bomb! Do you want to try again?", "BOOM!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tryAgain == DialogResult.Yes)
                {
                    FormLevel.ActiveForm.Text = "New Game";
                }
                else if (tryAgain == DialogResult.No)
                {
                    FormLevel.ActiveForm.Close();
                }
                return;
            }
            if (curRow + 1 < playBoardMatrix.GetLength(0))
            {
                if (playBoardMatrix[curRow + 1, curCol] == 1)
                {
                    minesAround++;
                }
            }
            if (curCol + 1 < playBoardMatrix.GetLength(1) && curRow + 1 < playBoardMatrix.GetLength(0))
            {
                if (playBoardMatrix[curRow + 1, curCol + 1] == 1)
                {
                    minesAround++;
                }
            }
            if (curCol + 1 < playBoardMatrix.GetLength(1))
            {
                if (playBoardMatrix[curRow, curCol + 1] == 1)
                {
                    minesAround++;
                }
            }
            if (curRow - 1 >= 0)
            {
                if (playBoardMatrix[curRow - 1, curCol] == 1)
                {
                    minesAround++;
                }
            }
            if (curCol - 1 >= 0)
            {
                if (playBoardMatrix[curRow, curCol - 1] == 1)
                {
                    minesAround++;
                }
            }
            if (curCol - 1 >= 0 && curRow - 1 >= 0)
            {
                if (playBoardMatrix[curRow - 1, curCol - 1] == 1)
                {
                    minesAround++;
                }
            }
            if (curRow + 1 < playBoardMatrix.GetLength(0) && curCol - 1 >= 0)
            {
                if (playBoardMatrix[curRow + 1, curCol - 1] == 1)
                {
                    minesAround++;
                }
            }
            if (curRow - 1 >= 0 && curCol + 1 < playBoardMatrix.GetLength(1))
            {
                if (playBoardMatrix[curRow - 1, curCol + 1] == 1)
                {
                    minesAround++;
                }
            }
            clickedButton.Text = minesAround.ToString();
            clickedButton.Enabled = false;
            clickedButton.BackColor = Color.LightGray;
        }
        public void IsWinner(Button[,] buttons)
        {
            bool isBomb = true;
            for (int row = 0; row < buttons.GetLength(0); row++)
            {
                for (int col = 0; col < buttons.GetLength(1); col++)
                {
                    if (buttons[row, col].Enabled == true)
                    {
                        if (playBoardMatrix[row, col] == 0)
                        {
                            isBomb = false;
                        }
                    }
                }
            }
            if (isBomb)
            {
                MessageBox.Show("You Won","WINNER");
                FormLevel.ActiveForm.Close();
            }
        }
    }
}
