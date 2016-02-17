using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public class Mines
    {
        //Initialize playBoard as matrix
        private static sbyte[,] playBoardMatrix = new sbyte[6, 6];
        //Initialize Playboard object
        private Playboard playBoard = new Playboard();
        //Inialize FormLevelOne object
        public Mines()
        {

        }

        //On FormLoad generate randomlly the mines onto the playBoard
        public void Generate()
        {
            sbyte mines = 6;
            Random generateBomb = new Random();

            //Iterate through the Play Board until all mines are positioned(when mines = 0)
            while (mines > 0)
            {
                for (int row = 1; row < playBoardMatrix.GetLength(0) - 1; row++)
                {
                    for (int col = 1; col < playBoardMatrix.GetLength(1) - 1; col++)
                    {
                        //If the current cell has a mine skip it
                        if (playBoardMatrix[row, col] != 1 && generateBomb.Next(0, 6) == 1)
                        {
                            playBoardMatrix[row, col] = 1;
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
        }
        public void CheckForMines(Button clickedButton, Button[,] buttons)
        {
            sbyte[] rowCol = clickedButton.Name.ToString().Split(new string[] { "btnR", "C" }, StringSplitOptions.RemoveEmptyEntries).Select(sbyte.Parse).ToArray();
            sbyte curRow = rowCol[0];
            sbyte curCol = rowCol[1];
            sbyte minesAround = 0;
            string mines = "";

            //Check if the current cell is outside of the playboard
            if (curRow < 0 || curCol < 0 || curRow == playBoardMatrix.GetLength(0) || curCol == playBoardMatrix.GetLength(1))
            {
                return;
            }
            if (playBoardMatrix[curRow, curCol] == 1)
            {
                //FormLevelOne frmLevelOne = new FormLevelOne();
                //FormLvlSelection frmLevelSelection = new FormLvlSelection();
                playBoard.ClickBombs(buttons, playBoardMatrix);
                DialogResult tryAgain = MessageBox.Show("You have hit a mine! Do you want to try again? ", "BOOM!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (tryAgain == DialogResult.Yes)
                //{
                //    frmLevelOne.Close();
                //    frmLevelSelection.Visible = true;
                //}
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

            if (clickedButton.Text == "0")
            {
                playBoard.ClearField(clickedButton, buttons, curRow, curCol);
            }
        }
    }
}
