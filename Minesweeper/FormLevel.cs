using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Minesweeper
{
    public partial class FormLevel : Form
    {

        //Initialize object of type MineControler
        Playboard buttons = new Playboard();
        Mines mines = new Mines();
        private sbyte numMines;
        private sbyte rows;
        private sbyte cols;

        public FormLevel(sbyte mines, sbyte numRows, sbyte numCols)
        {
            InitializeComponent();
            numMines = mines;
            rows = numRows;
            cols = numCols;
        }

        private void FormLevel_Load(object sender, EventArgs e)
        {
            FormLvlSelection.ActiveForm.Hide();
            if (rows == 30)
            {
                this.Size = new Size(25 * (rows + 2), 25 * (cols + 3));
            }
            else
            {
                this.Size = new Size(25 * (cols + 2), 25 * (rows + 3));
            }
            mines.Generate(numMines, rows, cols);
            Button[,] fields = new Button[rows, cols];
            int x = 25;
            int y = 25;
            for (int i = 0; i < fields.GetLength(0); i++)
            {
                for (int j = 0; j < fields.GetLength(1); j++)
                {
                    Button btn = new Button();
                    btn.BackColor = Color.White;
                    btn.Text = "";
                    btn.Location = new Point(x + (25 * i), y + (25 * j));
                    btn.Size = new Size(25, 25);
                    btn.Name = string.Format("btnR{0}C{1}", i, j);
                    btn.Click += (sender1, ex) =>
                    {
                        mines.CheckForMines(btn, fields);
                        if (btn.Text == "0")
                        {
                            buttons.ClearField(btn, fields);
                        }
                    };
                    fields[i, j] = btn;
                    this.Controls.Add(btn);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLevel.ActiveForm.Hide();
        }
    }
}