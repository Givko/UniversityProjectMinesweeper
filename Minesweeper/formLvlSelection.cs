using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class FormLvlSelection : Form
    {
        public FormLvlSelection()
        {
            InitializeComponent();
        }

        private void FormLvlSelection_Load(object sender, EventArgs e)
        {

        }
        private void pbLvlOne_Click(object sender, EventArgs e)
        {
            FormLevel levelOne = new FormLevel(15, 9, 9);
            levelOne.Text = "Level One";
            levelOne.FormClosed += (sender1, ex2) => this.Close();
            levelOne.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormLevel levelTwo = new FormLevel(60, 16, 16);
            levelTwo.Text = "Level Two";
            levelTwo.FormClosed += (sender1, ex) => this.Close();
            levelTwo.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormLevel levelThree = new FormLevel(99, 30, 16);
            levelThree.Text = "Level Three";
            levelThree.FormClosed += (sender1, ex1) => this.Close();
            levelThree.ShowDialog();
        }
    }
}
