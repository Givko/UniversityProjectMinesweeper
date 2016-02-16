using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public class Mines
    {
        //Initialize playBoard as matrix
        private static sbyte[,] playBoard = new sbyte[7, 7];
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
                for (int row = 0; row < playBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < playBoard.GetLength(1); col++)
                    {
                        //If the current cell has a mine skip it
                        if (playBoard[row, col] != 1 && generateBomb.Next(0, 6) == 1)
                        {
                            playBoard[row, col] = 1;
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
        public void CheckForMines(Button clickedButton)
        {
            sbyte[] rowCol = clickedButton.Name.ToString().Split(new string[] { "btnR", "C" }, StringSplitOptions.RemoveEmptyEntries).Select(sbyte.Parse).ToArray();
            sbyte row = rowCol[0];
            sbyte col = rowCol[1];
            sbyte minesAround = 0;
            string mines = "";

            //Check if the current cell is outside of the playboard
            if (row < 0 || col < 0 || row == playBoard.GetLength(0) || col == playBoard.GetLength(1))
            {
                return;
            }
            if (playBoard[row, col] == 1)
            {
                MessageBox.Show("You have hit a mine!", "BOOM!");
                clickedButton.Enabled = false;
                return;
            }
            if (row + 1 < playBoard.GetLength(0))
            {
                if (playBoard[row + 1, col] == 1)
                {
                    minesAround++;
                }
            }
            if (col + 1 < playBoard.GetLength(1) && row + 1 < playBoard.GetLength(0))
            {
                if (playBoard[row + 1, col + 1] == 1)
                {
                    minesAround++;
                }
            }
            if (col + 1 < playBoard.GetLength(1))
            {
                if (playBoard[row, col + 1] == 1)
                {
                    minesAround++;
                }
            }
            if (row - 1 >= 0)
            {
                if (playBoard[row - 1, col] == 1)
                {
                    minesAround++;
                }
            }
            if (col - 1 >= 0)
            {
                if (playBoard[row, col - 1] == 1)
                {
                    minesAround++;
                }
            }
            if (col - 1 >= 0 && row - 1 >= 0)
            {
                if (playBoard[row - 1, col - 1] == 1)
                {
                    minesAround++;
                }
            }

            if (row + 1 < playBoard.GetLength(0) && col - 1 >= 0)
            {
                if (playBoard[row + 1, col - 1] == 1)
                {
                    minesAround++;
                }
            }

            if (row - 1 >= 0 && col + 1 < playBoard.GetLength(1))
            {
                if (playBoard[row - 1, col + 1] == 1)
                {
                    minesAround++;
                }
            }
            clickedButton.Text = minesAround.ToString();
            clickedButton.Enabled = false;
        }
    }
}
