namespace Minesweeper
{
    partial class FormLvlSelection
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
            this.lblLvlOneInfo = new System.Windows.Forms.Label();
            this.lblLvlTwoInfo = new System.Windows.Forms.Label();
            this.lblLvlThreeInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLevelThree = new System.Windows.Forms.PictureBox();
            this.pbLevelTwo = new System.Windows.Forms.PictureBox();
            this.pbLvlOne = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLvlOne)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLvlOneInfo
            // 
            this.lblLvlOneInfo.AutoSize = true;
            this.lblLvlOneInfo.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLvlOneInfo.Location = new System.Drawing.Point(9, 145);
            this.lblLvlOneInfo.Name = "lblLvlOneInfo";
            this.lblLvlOneInfo.Size = new System.Drawing.Size(93, 38);
            this.lblLvlOneInfo.TabIndex = 3;
            this.lblLvlOneInfo.Text = "Playboard: 9x9\r\nMines: 10";
            // 
            // lblLvlTwoInfo
            // 
            this.lblLvlTwoInfo.AutoSize = true;
            this.lblLvlTwoInfo.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLvlTwoInfo.Location = new System.Drawing.Point(145, 141);
            this.lblLvlTwoInfo.Name = "lblLvlTwoInfo";
            this.lblLvlTwoInfo.Size = new System.Drawing.Size(106, 38);
            this.lblLvlTwoInfo.TabIndex = 4;
            this.lblLvlTwoInfo.Text = "Playboard 16x16\r\nMines: 40";
            // 
            // lblLvlThreeInfo
            // 
            this.lblLvlThreeInfo.AutoSize = true;
            this.lblLvlThreeInfo.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLvlThreeInfo.Location = new System.Drawing.Point(281, 145);
            this.lblLvlThreeInfo.Name = "lblLvlThreeInfo";
            this.lblLvlThreeInfo.Size = new System.Drawing.Size(106, 38);
            this.lblLvlThreeInfo.TabIndex = 5;
            this.lblLvlThreeInfo.Text = "Playboard 16x30\r\nMine: 99";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please, select level.";
            // 
            // pbLevelThree
            // 
            this.pbLevelThree.Image = global::Minesweeper.Properties.Resources.lvl3;
            this.pbLevelThree.Location = new System.Drawing.Point(284, 30);
            this.pbLevelThree.Name = "pbLevelThree";
            this.pbLevelThree.Size = new System.Drawing.Size(109, 108);
            this.pbLevelThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLevelThree.TabIndex = 2;
            this.pbLevelThree.TabStop = false;
            this.pbLevelThree.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbLevelTwo
            // 
            this.pbLevelTwo.Image = global::Minesweeper.Properties.Resources.lvl2;
            this.pbLevelTwo.Location = new System.Drawing.Point(148, 30);
            this.pbLevelTwo.Name = "pbLevelTwo";
            this.pbLevelTwo.Size = new System.Drawing.Size(109, 108);
            this.pbLevelTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLevelTwo.TabIndex = 1;
            this.pbLevelTwo.TabStop = false;
            this.pbLevelTwo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbLvlOne
            // 
            this.pbLvlOne.Image = global::Minesweeper.Properties.Resources.download;
            this.pbLvlOne.Location = new System.Drawing.Point(12, 30);
            this.pbLvlOne.Name = "pbLvlOne";
            this.pbLvlOne.Size = new System.Drawing.Size(109, 108);
            this.pbLvlOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLvlOne.TabIndex = 0;
            this.pbLvlOne.TabStop = false;
            this.pbLvlOne.Click += new System.EventHandler(this.pbLvlOne_Click);
            // 
            // FormLvlSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(421, 193);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLvlThreeInfo);
            this.Controls.Add(this.lblLvlTwoInfo);
            this.Controls.Add(this.lblLvlOneInfo);
            this.Controls.Add(this.pbLevelThree);
            this.Controls.Add(this.pbLevelTwo);
            this.Controls.Add(this.pbLvlOne);
            this.Name = "FormLvlSelection";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.FormLvlSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLvlOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLvlOne;
        private System.Windows.Forms.PictureBox pbLevelTwo;
        private System.Windows.Forms.PictureBox pbLevelThree;
        private System.Windows.Forms.Label lblLvlOneInfo;
        private System.Windows.Forms.Label lblLvlTwoInfo;
        private System.Windows.Forms.Label lblLvlThreeInfo;
        private System.Windows.Forms.Label label1;
    }
}

