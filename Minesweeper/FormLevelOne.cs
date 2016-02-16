using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class FormLevelOne : Form
    {

        //Initialize object of type MineControler
        Buttons buttons = new Buttons();
        Mines mines = new Mines();

        public FormLevelOne()
        {
            InitializeComponent();

        }

        private void FormLevelOne_Load(object sender, EventArgs e)
        {
            mines.Generate();
            Button[,] fields = new Button[7, 7];
            int x = 45;
            int y = 35;
            for (int i = 0; i < fields.GetLength(0); i++)
            {
                for (int j = 0; j < fields.GetLength(1); j++)
                {

                    Button btn = new Button();
                    fields[i, j] = btn;
                    btn.BackColor = Color.White;
                    btn.Text = "";
                    btn.Location = new System.Drawing.Point(x * (i+1), y *(j+1));
                    btn.Size = new System.Drawing.Size(45,40);
                    btn.Name = string.Format("btnR{0}", i);
                    
                    this.panel1.Controls.Add(btn);
                }
            }
        }
        private void btnR0C0_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR0C0);
            if (btnR0C0.Text == "0")
            {
                btnR0C1.PerformClick();
                btnR1C1.PerformClick();
                btnR1C0.PerformClick();
            }
        }

        private void btnR0C1_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR0C1);
            if (btnR0C1.Text == "0")
            {
                btnR0C2.PerformClick();
                btnR1C0.PerformClick();
                btnR0C0.PerformClick();
                btnR1C2.PerformClick();
                btnR1C1.PerformClick();
            }

        }

        private void btnR0C2_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR0C2);
            if (btnR0C2.Text == "0")
            {
                btnR0C3.PerformClick();
                btnR0C1.PerformClick();
                btnR1C1.PerformClick();
                btnR1C2.PerformClick();
                btnR1C3.PerformClick();
            }
        }

        private void btnR0C3_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR0C3);
            if (btnR0C3.Text == "0")
            {
                btnR0C4.PerformClick();
                btnR0C2.PerformClick();
                btnR1C2.PerformClick();
                btnR1C3.PerformClick();
                btnR1C4.PerformClick();
            }
        }

        private void btnR0C4_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR0C4);
            if (btnR0C4.Text == "0")
            {
                btnR0C3.PerformClick();
                btnR0C5.PerformClick();
                btnR1C3.PerformClick();
                btnR1C4.PerformClick();
                btnR1C5.PerformClick();
            }
        }

        private void btnR0C5_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR0C5);
            if (btnR0C5.Text == "0")
            {
                btnR0C4.PerformClick();
                btnR1C4.PerformClick();
                btnR1C5.PerformClick();
            }
        }
        private void btnR1C0_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR1C0);
            if (btnR1C0.Text == "0")
            {
                btnR1C1.PerformClick();
                btnR0C1.PerformClick();
                btnR0C0.PerformClick();
                btnR2C0.PerformClick();
                btnR2C1.PerformClick();
                btnR2C2.PerformClick();
            }
        }

        private void btnR1C1_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR1C1);
            if (btnR1C1.Text == "0")
            {
                btnR1C0.PerformClick();
                btnR1C2.PerformClick();
                btnR0C0.PerformClick();
                btnR0C1.PerformClick();
                btnR0C2.PerformClick();
                btnR2C0.PerformClick();
                btnR2C1.PerformClick();
                btnR2C2.PerformClick();
            }
        }

        private void btnR1C2_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR1C2);
            if (btnR1C2.Text == "0")
            {
                btnR1C1.PerformClick();
                btnR1C3.PerformClick();
                btnR0C1.PerformClick();
                btnR0C2.PerformClick();
                btnR0C3.PerformClick();
                btnR2C1.PerformClick();
                btnR2C2.PerformClick();
                btnR2C3.PerformClick();
            }
        }

        private void btnR1C3_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR1C3);
            if (btnR1C3.Text == "0")
            {
                btnR1C2.PerformClick();
                btnR1C4.PerformClick();
                btnR0C2.PerformClick();
                btnR0C3.PerformClick();
                btnR0C4.PerformClick();
                btnR2C2.PerformClick();
                btnR2C3.PerformClick();
                btnR2C4.PerformClick();
            }
        }

        private void btnR1C4_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR1C4);
            if (btnR1C4.Text == "0")
            {
                btnR1C3.PerformClick();
                btnR1C5.PerformClick();
                btnR0C3.PerformClick();
                btnR0C4.PerformClick();
                btnR0C5.PerformClick();
                btnR2C3.PerformClick();
                btnR2C4.PerformClick();
                btnR2C5.PerformClick();
            }
        }

        private void btnR1C5_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR1C5);
            if (btnR1C5.Text == "0")
            {
                btnR1C4.PerformClick();
                btnR0C4.PerformClick();
                btnR0C5.PerformClick();
                btnR2C4.PerformClick();
                btnR2C5.PerformClick();
            }
        }

        private void btnR2C0_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR2C0);
            if (btnR2C0.Text == "0")
            {
                btnR2C1.PerformClick();
                btnR1C0.PerformClick();
                btnR1C1.PerformClick();
                btnR3C0.PerformClick();
                btnR3C1.PerformClick();
            }
        }

        private void btnR2C1_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR2C1);
            if (btnR2C1.Text == "0")
            {
                btnR2C0.PerformClick();
                btnR2C2.PerformClick();
                btnR1C0.PerformClick();
                btnR1C1.PerformClick();
                btnR1C2.PerformClick();
                btnR3C0.PerformClick();
                btnR3C1.PerformClick();
                btnR3C2.PerformClick();
            }
        }

        private void btnR2C2_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR2C2);
            if (btnR2C2.Text == "0")
            {
                btnR2C1.PerformClick();
                btnR2C3.PerformClick();
                btnR1C1.PerformClick();
                btnR1C2.PerformClick();
                btnR1C3.PerformClick();
                btnR3C1.PerformClick();
                btnR3C2.PerformClick();
                btnR3C3.PerformClick();
            }
        }

        private void btnR2C3_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR2C3);
            if (btnR2C3.Text == "0")
            {
                btnR2C2.PerformClick();
                btnR2C4.PerformClick();
                btnR1C2.PerformClick();
                btnR1C3.PerformClick();
                btnR1C4.PerformClick();
                btnR3C2.PerformClick();
                btnR3C3.PerformClick();
                btnR3C4.PerformClick();
            }
        }

        private void btnR2C4_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR2C4);
            if (btnR2C4.Text == "0")
            {
                btnR2C3.PerformClick();
                btnR2C5.PerformClick();
                btnR1C3.PerformClick();
                btnR1C4.PerformClick();
                btnR1C5.PerformClick();
                btnR3C3.PerformClick();
                btnR3C4.PerformClick();
                btnR3C5.PerformClick();
            }
        }

        private void btnR2C5_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR2C5);
            if (btnR2C5.Text == "0")
            {
                btnR2C4.PerformClick();
                btnR1C4.PerformClick();
                btnR1C5.PerformClick();
                btnR3C4.PerformClick();
                btnR3C5.PerformClick();
            }
        }

        private void btnR3C0_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR3C0);
            if (btnR3C0.Text == "0")
            {
                btnR3C1.PerformClick();
                btnR2C0.PerformClick();
                btnR2C1.PerformClick();
                btnR4C0.PerformClick();
                btnR4C1.PerformClick();
            }
        }

        private void btnR3C1_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR3C1);
            if (btnR3C1.Text == "0")
            {
                btnR3C0.PerformClick();
                btnR3C2.PerformClick();
                btnR2C0.PerformClick();
                btnR2C1.PerformClick();
                btnR2C2.PerformClick();
                btnR4C0.PerformClick();
                btnR4C1.PerformClick();
                btnR4C2.PerformClick();
            }
        }

        private void btnR3C2_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR3C2);
            if (btnR3C2.Text == "0")
            {
                btnR3C1.PerformClick();
                btnR3C3.PerformClick();
                btnR2C1.PerformClick();
                btnR2C2.PerformClick();
                btnR2C3.PerformClick();
                btnR4C1.PerformClick();
                btnR4C2.PerformClick();
                btnR4C3.PerformClick();
            }
        }

        private void btnR3C3_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR3C3);
            if (btnR3C3.Text == "0")
            {
                btnR3C2.PerformClick();
                btnR3C4.PerformClick();
                btnR2C2.PerformClick();
                btnR2C3.PerformClick();
                btnR2C4.PerformClick();
                btnR4C2.PerformClick();
                btnR4C3.PerformClick();
                btnR4C4.PerformClick();
            }
        }

        private void btnR3C4_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR3C4);
            if (btnR3C4.Text == "0")
            {
                btnR3C3.PerformClick();
                btnR3C5.PerformClick();
                btnR2C3.PerformClick();
                btnR2C4.PerformClick();
                btnR2C5.PerformClick();
                btnR4C3.PerformClick();
                btnR4C4.PerformClick();
                btnR4C5.PerformClick();
            }
        }

        private void btnR3C5_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR3C5);
            if (btnR3C5.Text == "0")
            {
                btnR3C4.PerformClick();
                btnR2C4.PerformClick();
                btnR2C5.PerformClick();
                btnR4C4.PerformClick();
                btnR4C5.PerformClick();
            }
        }

        private void btnR4C0_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR4C0);
            if (btnR4C0.Text == "0")
            {
                btnR4C1.PerformClick();
                btnR3C0.PerformClick();
                btnR3C1.PerformClick();
                btnR5C0.PerformClick();
                btnR5C1.PerformClick();
            }
        }

        private void btnR4C1_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR4C1);
            if (btnR4C1.Text == "0")
            {
                btnR4C0.PerformClick();
                btnR4C2.PerformClick();
                btnR3C0.PerformClick();
                btnR3C1.PerformClick();
                btnR3C2.PerformClick();
                btnR5C0.PerformClick();
                btnR5C1.PerformClick();
                btnR5C2.PerformClick();
            }
        }

        private void btnR4C2_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR4C2);
            if (btnR4C2.Text == "0")
            {
                btnR4C1.PerformClick();
                btnR4C3.PerformClick();
                btnR3C1.PerformClick();
                btnR3C2.PerformClick();
                btnR3C3.PerformClick();
                btnR5C1.PerformClick();
                btnR5C2.PerformClick();
                btnR5C3.PerformClick();
            }
        }

        private void btnR4C3_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR4C3);
            if (btnR4C3.Text == "0")
            {
                btnR4C2.PerformClick();
                btnR4C4.PerformClick();
                btnR3C2.PerformClick();
                btnR3C3.PerformClick();
                btnR3C4.PerformClick();
                btnR5C2.PerformClick();
                btnR5C3.PerformClick();
                btnR5C4.PerformClick();
            }
        }

        private void btnR4C4_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR4C4);
            if (btnR4C4.Text == "0")
            {
                btnR4C3.PerformClick();
                btnR4C5.PerformClick();
                btnR3C3.PerformClick();
                btnR3C4.PerformClick();
                btnR3C5.PerformClick();
                btnR5C3.PerformClick();
                btnR5C4.PerformClick();
                btnR5C5.PerformClick();
            }
        }

        private void btnR4C5_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR4C5);
            if (btnR4C5.Text == "0")
            {
                btnR4C4.PerformClick();
                btnR3C4.PerformClick();
                btnR3C5.PerformClick();
                btnR5C4.PerformClick();
                btnR5C5.PerformClick();
            }
        }

        private void btnR5C0_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR5C0);
            if (btnR5C0.Text == "0")
            {
                btnR5C1.PerformClick();
                btnR4C0.PerformClick();
                btnR4C1.PerformClick();
            }
        }

        private void btnR5C1_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR5C1);
            if (btnR5C1.Text == "0")
            {
                btnR5C0.PerformClick();
                btnR5C2.PerformClick();
                btnR4C0.PerformClick();
                btnR4C1.PerformClick();
                btnR4C2.PerformClick();
            }
        }

        private void btnR5C2_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR5C2);
            if (btnR5C2.Text == "0")
            {
                btnR5C1.PerformClick();
                btnR5C3.PerformClick();
                btnR4C1.PerformClick();
                btnR4C2.PerformClick();
                btnR4C3.PerformClick();
            }
        }

        private void btnR5C3_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR5C3);
            if (btnR5C3.Text == "0")
            {
                btnR5C2.PerformClick();
                btnR5C4.PerformClick();
                btnR4C2.PerformClick();
                btnR4C3.PerformClick();
                btnR4C4.PerformClick();
            }
        }

        private void btnR5C4_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR5C4);
            if (btnR5C4.Text == "0")
            {
                btnR5C3.PerformClick();
                btnR5C5.PerformClick();
                btnR4C3.PerformClick();
                btnR4C4.PerformClick();
                btnR4C5.PerformClick();
            }
        }

        private void btnR5C5_Click(object sender, EventArgs e)
        {
            mines.CheckForMines(btnR5C5);
            if (btnR5C5.Text == "0")
            {
                btnR5C4.PerformClick();
                btnR4C4.PerformClick();
                btnR4C5.PerformClick();
            }
        }

        private void btnR0C0_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void FormLevelOne_Activated(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}