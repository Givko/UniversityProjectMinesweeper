namespace Minesweeper
{
    partial class FormLevel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripLvlOne = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMinesweeperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLvlOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripLvlOne
            // 
            this.menuStripLvlOne.BackColor = System.Drawing.Color.Silver;
            this.menuStripLvlOne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripLvlOne.Location = new System.Drawing.Point(0, 0);
            this.menuStripLvlOne.Name = "menuStripLvlOne";
            this.menuStripLvlOne.Size = new System.Drawing.Size(439, 24);
            this.menuStripLvlOne.TabIndex = 0;
            this.menuStripLvlOne.Text = "menuStripLvlOne";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeLevelToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutMinesweeperToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // aboutMinesweeperToolStripMenuItem
            // 
            this.aboutMinesweeperToolStripMenuItem.Name = "aboutMinesweeperToolStripMenuItem";
            this.aboutMinesweeperToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutMinesweeperToolStripMenuItem.Text = "About Minesweeper";
            // 
            // changeLevelToolStripMenuItem
            // 
            this.changeLevelToolStripMenuItem.Name = "changeLevelToolStripMenuItem";
            this.changeLevelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.changeLevelToolStripMenuItem.Text = "Change Level";
            this.changeLevelToolStripMenuItem.Click += new System.EventHandler(this.changeLevelToolStripMenuItem_Click);
            // 
            // FormLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(439, 293);
            this.Controls.Add(this.menuStripLvlOne);
            this.MainMenuStrip = this.menuStripLvlOne;
            this.Name = "FormLevel";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.FormLevel_Load);
            this.menuStripLvlOne.ResumeLayout(false);
            this.menuStripLvlOne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripLvlOne;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMinesweeperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLevelToolStripMenuItem;
    }
}