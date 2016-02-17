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
        Playboard buttons = new Playboard();
        Mines mines = new Mines();

        public FormLevelOne()
        {
            InitializeComponent();

        }

        private void FormLevelOne_Load(object sender, EventArgs e)
        {
            mines.Generate();
            Button[,] fields = new Button[6, 6];
            int x = 45;
            int y = 35;
            for (int i = 0; i < fields.GetLength(0); i++)
            {
                for (int j = 0; j < fields.GetLength(1); j++)
                {

                    Button btn = new Button();
                    btn.BackColor = Color.White;
                    btn.Text = "";
                    btn.Location = new System.Drawing.Point(x * (i + 1), y * (j + 1));
                    btn.Size = new System.Drawing.Size(47, 40);
                    btn.Name = string.Format("btnR{0}C{1}", i, j);
                    btn.Click += (sender1, ex) => mines.CheckForMines(btn, fields);
                    fields[i, j] = btn;
                    this.Controls.Add(btn);
                }
            }
        }
        private void FormLevelOne_Activated(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}