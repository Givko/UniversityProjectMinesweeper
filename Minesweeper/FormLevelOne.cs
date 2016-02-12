using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class FormLevelOne : Form
    {
        //Initialize playBoard as matrix
        sbyte[,] playBoard = new sbyte[6, 6];

        public FormLevelOne()
        {
            InitializeComponent();
        }

        //On FormLoad generate randomlly the mines onto the playBoard(not fully working) need to finish callig it recursivly and to call the button and write the number of mines around it)
        private void FormLevelOne_Load(object sender, EventArgs e)
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
                        if (playBoard[row, col] != 1 && generateBomb.Next(0, 4) == 1)
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
        //Check how many mines are around the clicked button
        private void CheckForMines(sbyte[] rowAndCOl)
        {
            sbyte row = rowAndCOl[0];
            sbyte col = rowAndCOl[1];
            sbyte minesAround = 0;

            //Check if the current cell is outside of the playboard
            if (row < 0 || col < 0 || row == playBoard.GetLength(0) || col == playBoard.GetLength(1))
            {
                return;
            }
            if (playBoard[row,col]==1)
            {
                MessageBox.Show("You have hit a mine!");
                return;
            }
            if (row + 1 < playBoard.GetLength(0))
            {
                if (playBoard[row + 1, col] == 1)
                {
                    minesAround++;
                }
                if (col + 1 < playBoard.GetLength(1))
                {
                    if (playBoard[row, col + 1] == 1)
                    {
                        minesAround++;
                    }
                    if (playBoard[row + 1, col + 1] == 1)
                    {
                        minesAround++;
                    }
                }
            }

            if (row - 1 >= 0)
            {
                if (playBoard[row - 1, col] == 1)
                {
                    minesAround++;
                }
                if (col - 1 >= 0)
                {
                    if (playBoard[row, col - 1] == 1)
                    {
                        minesAround++;
                    }
                    if (playBoard[row - 1, col - 1] == 1)
                    {
                        minesAround++;
                    }
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
                if (playBoard[row-1,col+1]==1)
                {
                    minesAround++;
                }
            }
            
        }

        private void btnR0C0_Click(object sender, EventArgs e)
        {
            sbyte[] rowCol = btnR0C0.Name.ToString().Split(new string[] {"btnR","C"},StringSplitOptions.RemoveEmptyEntries).Select(sbyte.Parse).ToArray();
            CheckForMines(rowCol);
        }
    }
}