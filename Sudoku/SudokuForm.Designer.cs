namespace Sudoku
{
    partial class SudokuMainForm
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
            this.ButtonsPnl = new System.Windows.Forms.Panel();
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.SudokuPnl = new System.Windows.Forms.Panel();
            this.Separator4 = new System.Windows.Forms.Panel();
            this.Separator3 = new System.Windows.Forms.Panel();
            this.Separator2 = new System.Windows.Forms.Panel();
            this.Separator1 = new System.Windows.Forms.Panel();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.HintBtn = new System.Windows.Forms.Button();
            this.ErrorCheckBtn = new System.Windows.Forms.Button();
            this.HintsLbl = new System.Windows.Forms.Label();
            this.ChecksLbl = new System.Windows.Forms.Label();
            this.HintCountLbl = new System.Windows.Forms.Label();
            this.ChecksCountLbl = new System.Windows.Forms.Label();
            this.HintsPnl = new System.Windows.Forms.Panel();
            this.SudokuPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPnl
            // 
            this.ButtonsPnl.BackColor = System.Drawing.Color.Transparent;
            this.ButtonsPnl.Location = new System.Drawing.Point(381, 236);
            this.ButtonsPnl.Name = "ButtonsPnl";
            this.ButtonsPnl.Size = new System.Drawing.Size(124, 122);
            this.ButtonsPnl.TabIndex = 0;
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Location = new System.Drawing.Point(11, 369);
            this.NewGameBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(108, 24);
            this.NewGameBtn.TabIndex = 1;
            this.NewGameBtn.Text = "New Game";
            this.NewGameBtn.UseVisualStyleBackColor = true;
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // SudokuPnl
            // 
            this.SudokuPnl.BackColor = System.Drawing.Color.Transparent;
            this.SudokuPnl.Controls.Add(this.Separator4);
            this.SudokuPnl.Controls.Add(this.Separator3);
            this.SudokuPnl.Controls.Add(this.Separator2);
            this.SudokuPnl.Controls.Add(this.ChecksLbl);
            this.SudokuPnl.Controls.Add(this.Separator1);
            this.SudokuPnl.Location = new System.Drawing.Point(13, 1);
            this.SudokuPnl.Name = "SudokuPnl";
            this.SudokuPnl.Size = new System.Drawing.Size(362, 357);
            this.SudokuPnl.TabIndex = 2;
            // 
            // Separator4
            // 
            this.Separator4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Separator4.Location = new System.Drawing.Point(0, 235);
            this.Separator4.Name = "Separator4";
            this.Separator4.Size = new System.Drawing.Size(355, 3);
            this.Separator4.TabIndex = 3;
            // 
            // Separator3
            // 
            this.Separator3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Separator3.Location = new System.Drawing.Point(0, 117);
            this.Separator3.Name = "Separator3";
            this.Separator3.Size = new System.Drawing.Size(355, 3);
            this.Separator3.TabIndex = 2;
            // 
            // Separator2
            // 
            this.Separator2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Separator2.Location = new System.Drawing.Point(236, 2);
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(3, 355);
            this.Separator2.TabIndex = 1;
            // 
            // Separator1
            // 
            this.Separator1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Separator1.Location = new System.Drawing.Point(116, 2);
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(3, 355);
            this.Separator1.TabIndex = 0;
            // 
            // FinishBtn
            // 
            this.FinishBtn.Location = new System.Drawing.Point(353, 370);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(106, 23);
            this.FinishBtn.TabIndex = 3;
            this.FinishBtn.Text = "Finish";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(129, 370);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(106, 23);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save Game";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(241, 370);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(106, 23);
            this.LoadBtn.TabIndex = 5;
            this.LoadBtn.Text = "Load Game";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // HintBtn
            // 
            this.HintBtn.Location = new System.Drawing.Point(0, 0);
            this.HintBtn.Name = "HintBtn";
            this.HintBtn.Size = new System.Drawing.Size(75, 23);
            this.HintBtn.TabIndex = 6;
            this.HintBtn.Text = "Hint";
            this.HintBtn.UseVisualStyleBackColor = true;
            this.HintBtn.Click += new System.EventHandler(this.HintBtn_Click);
            // 
            // ErrorCheckBtn
            // 
            this.ErrorCheckBtn.Location = new System.Drawing.Point(0, 90);
            this.ErrorCheckBtn.Name = "ErrorCheckBtn";
            this.ErrorCheckBtn.Size = new System.Drawing.Size(75, 23);
            this.ErrorCheckBtn.TabIndex = 7;
            this.ErrorCheckBtn.Text = "Error Check";
            this.ErrorCheckBtn.UseVisualStyleBackColor = true;
            this.ErrorCheckBtn.Click += new System.EventHandler(this.ErrorCheckBtn_Click);
            // 
            // HintsLbl
            // 
            this.HintsLbl.AutoSize = true;
            this.HintsLbl.BackColor = System.Drawing.Color.Transparent;
            this.HintsLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HintsLbl.Location = new System.Drawing.Point(0, 40);
            this.HintsLbl.Name = "HintsLbl";
            this.HintsLbl.Size = new System.Drawing.Size(51, 13);
            this.HintsLbl.TabIndex = 8;
            this.HintsLbl.Text = "Hints left:";
            // 
            // ChecksLbl
            // 
            this.ChecksLbl.AutoSize = true;
            this.ChecksLbl.BackColor = System.Drawing.Color.Transparent;
            this.ChecksLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChecksLbl.Location = new System.Drawing.Point(-1, 129);
            this.ChecksLbl.Name = "ChecksLbl";
            this.ChecksLbl.Size = new System.Drawing.Size(63, 13);
            this.ChecksLbl.TabIndex = 9;
            this.ChecksLbl.Text = "Checks left:";
            // 
            // HintCountLbl
            // 
            this.HintCountLbl.AutoSize = true;
            this.HintCountLbl.BackColor = System.Drawing.Color.Transparent;
            this.HintCountLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HintCountLbl.Location = new System.Drawing.Point(60, 40);
            this.HintCountLbl.Name = "HintCountLbl";
            this.HintCountLbl.Size = new System.Drawing.Size(13, 13);
            this.HintCountLbl.TabIndex = 10;
            this.HintCountLbl.Text = "0";
            // 
            // ChecksCountLbl
            // 
            this.ChecksCountLbl.AutoSize = true;
            this.ChecksCountLbl.BackColor = System.Drawing.Color.Transparent;
            this.ChecksCountLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChecksCountLbl.Location = new System.Drawing.Point(60, 130);
            this.ChecksCountLbl.Name = "ChecksCountLbl";
            this.ChecksCountLbl.Size = new System.Drawing.Size(13, 13);
            this.ChecksCountLbl.TabIndex = 11;
            this.ChecksCountLbl.Text = "0";
            // 
            // HintsPnl
            // 
            this.HintsPnl.BackColor = System.Drawing.Color.Transparent;
            this.HintsPnl.Location = new System.Drawing.Point(381, 62);
            this.HintsPnl.Name = "HintsPnl";
            this.HintsPnl.Size = new System.Drawing.Size(124, 168);
            this.HintsPnl.TabIndex = 4;
            // 
            // SudokuMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(515, 399);
            this.Controls.Add(this.HintsPnl);
            this.Controls.Add(this.ChecksCountLbl);
            this.Controls.Add(this.HintCountLbl);
            this.Controls.Add(this.HintsLbl);
            this.Controls.Add(this.ErrorCheckBtn);
            this.Controls.Add(this.HintBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.SudokuPnl);
            this.Controls.Add(this.NewGameBtn);
            this.Controls.Add(this.ButtonsPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SudokuMainForm";
            this.Text = "Sudoku";
            this.SudokuPnl.ResumeLayout(false);
            this.SudokuPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsPnl;
        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.Panel SudokuPnl;
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Panel Separator4;
        private System.Windows.Forms.Panel Separator3;
        private System.Windows.Forms.Panel Separator2;
        private System.Windows.Forms.Panel Separator1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button HintBtn;
        private System.Windows.Forms.Button ErrorCheckBtn;
        private System.Windows.Forms.Label HintsLbl;
        private System.Windows.Forms.Label ChecksLbl;
        private System.Windows.Forms.Label HintCountLbl;
        private System.Windows.Forms.Label ChecksCountLbl;
        private System.Windows.Forms.Panel HintsPnl;


    }
}

