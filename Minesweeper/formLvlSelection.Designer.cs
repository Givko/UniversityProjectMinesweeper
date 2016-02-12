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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbLvlOne = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Minesweeper.Properties.Resources.lvl3;
            this.pictureBox2.Location = new System.Drawing.Point(284, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Minesweeper.Properties.Resources.lvl2;
            this.pictureBox1.Location = new System.Drawing.Point(148, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbLvlOne);
            this.Name = "FormLvlSelection";
            this.Text = "Minesweeper";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLvlOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLvlOne;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblLvlOneInfo;
        private System.Windows.Forms.Label lblLvlTwoInfo;
        private System.Windows.Forms.Label lblLvlThreeInfo;
        private System.Windows.Forms.Label label1;
    }
}

