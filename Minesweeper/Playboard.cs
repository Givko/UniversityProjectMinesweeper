using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    class Playboard
    {
        public void ClickBombs(Button[,] playboard, sbyte[,] fields)
        {
            for (int i = 0; i < playboard.GetLength(0); i++)
            {
                for (int j = 0; j < playboard.GetLength(1); j++)
                {
                    if (fields[i, j] == 1)
                    {
                        playboard[i, j].BackColor = Color.Red;
                        playboard[i, j].Enabled = false;
                    }
                }
            }
        }
        public void ClearField(Button clickedButton, Button[,] playBoard, int i, int j)
        {
            if (i == 0)
            {
                if (j == 0)
                {
                    playBoard[i, j + 1].PerformClick();
                    playBoard[i + 1, j].PerformClick();
                    playBoard[i + 1, j + 1].PerformClick();
                }
                else if (j == playBoard.GetLength(1) - 1)
                {
                    playBoard[i + 1, j].PerformClick();
                    playBoard[i + 1, j - 1].PerformClick();
                    playBoard[i, j - 1].PerformClick();
                }
                else
                {
                    playBoard[i, j - 1].PerformClick();
                    playBoard[i, j + 1].PerformClick();
                    playBoard[i + 1, j - 1].PerformClick();
                    playBoard[i + 1, j].PerformClick();
                    playBoard[i + 1, j + 1].PerformClick();
                }
            }
            else if (i == playBoard.GetLength(0) - 1)
            {
                if (j == 0)
                {
                    playBoard[i, j + 1].PerformClick();
                    playBoard[i - 1, j].PerformClick();
                    playBoard[i - 1, j + 1].PerformClick();
                }
                else if (j == playBoard.GetLength(1) - 1)
                {
                    playBoard[i - 1, j].PerformClick();
                    playBoard[i - 1, j - 1].PerformClick();
                    playBoard[i, j - 1].PerformClick();
                }
                else
                {
                    playBoard[i, j - 1].PerformClick();
                    playBoard[i, j + 1].PerformClick();
                    playBoard[i - 1, j - 1].PerformClick();
                    playBoard[i - 1, j].PerformClick();
                    playBoard[i - 1, j + 1].PerformClick();
                }
            }
            else if (j == 0)
            {
                playBoard[i, j + 1].PerformClick();
                playBoard[i - 1, j].PerformClick();
                playBoard[i - 1, j + 1].PerformClick();
                playBoard[i + 1, j].PerformClick();
                playBoard[i + 1, j + 1].PerformClick();
            }
            else if (j == playBoard.GetLength(1) - 1)
            {
                playBoard[i, j - 1].PerformClick();
                playBoard[i - 1, j].PerformClick();
                playBoard[i - 1, j - 1].PerformClick();
                playBoard[i + 1, j].PerformClick();
                playBoard[i + 1, j - 1].PerformClick();
            }
            else
            {
                playBoard[i, j - 1].PerformClick();
                playBoard[i, j + 1].PerformClick();
                playBoard[i - 1, j - 1].PerformClick();
                playBoard[i - 1, j].PerformClick();
                playBoard[i - 1, j + 1].PerformClick();
                playBoard[i + 1, j - 1].PerformClick();
                playBoard[i + 1, j].PerformClick();
                playBoard[i + 1, j + 1].PerformClick();
            }
        }
    }
}