namespace INFT2012Assignment
{
    partial class frmMain
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
            this.lbxPlayerList = new System.Windows.Forms.ListBox();
            this.lblPlayerList = new System.Windows.Forms.Label();
            this.lblTargetScore = new System.Windows.Forms.Label();
            this.lbxScoreTarget = new System.Windows.Forms.ListBox();
            this.btnGameStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxPlayerList
            // 
            this.lbxPlayerList.FormattingEnabled = true;
            this.lbxPlayerList.Location = new System.Drawing.Point(474, 23);
            this.lbxPlayerList.Name = "lbxPlayerList";
            this.lbxPlayerList.Size = new System.Drawing.Size(72, 30);
            this.lbxPlayerList.TabIndex = 1;
            // 
            // lblPlayerList
            // 
            this.lblPlayerList.AutoSize = true;
            this.lblPlayerList.Location = new System.Drawing.Point(471, 7);
            this.lblPlayerList.Name = "lblPlayerList";
            this.lblPlayerList.Size = new System.Drawing.Size(75, 13);
            this.lblPlayerList.TabIndex = 2;
            this.lblPlayerList.Text = "List of Players:";
            // 
            // lblTargetScore
            // 
            this.lblTargetScore.AutoSize = true;
            this.lblTargetScore.Location = new System.Drawing.Point(471, 56);
            this.lblTargetScore.Name = "lblTargetScore";
            this.lblTargetScore.Size = new System.Drawing.Size(72, 13);
            this.lblTargetScore.TabIndex = 3;
            this.lblTargetScore.Text = "Score Target:";
            // 
            // lbxScoreTarget
            // 
            this.lbxScoreTarget.FormattingEnabled = true;
            this.lbxScoreTarget.Location = new System.Drawing.Point(474, 72);
            this.lbxScoreTarget.Name = "lbxScoreTarget";
            this.lbxScoreTarget.Size = new System.Drawing.Size(72, 17);
            this.lbxScoreTarget.TabIndex = 4;
            // 
            // btnGameStart
            // 
            this.btnGameStart.Location = new System.Drawing.Point(213, 313);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(101, 23);
            this.btnGameStart.TabIndex = 5;
            this.btnGameStart.Text = "Ready to Play!";
            this.btnGameStart.UseVisualStyleBackColor = true;
            this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 357);
            this.Controls.Add(this.btnGameStart);
            this.Controls.Add(this.lbxScoreTarget);
            this.Controls.Add(this.lblTargetScore);
            this.Controls.Add(this.lblPlayerList);
            this.Controls.Add(this.lbxPlayerList);
            this.Name = "frmMain";
            this.Text = "PlusMoins";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbxPlayerList;
        private System.Windows.Forms.Label lblPlayerList;
        private System.Windows.Forms.Label lblTargetScore;
        private System.Windows.Forms.ListBox lbxScoreTarget;
        private System.Windows.Forms.Button btnGameStart;
    }
}

