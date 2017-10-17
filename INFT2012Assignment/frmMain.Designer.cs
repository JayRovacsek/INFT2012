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
            this.lblPlayersTurn = new System.Windows.Forms.Label();
            this.lbxPlayersTurn = new System.Windows.Forms.ListBox();
            this.lblNumberOfPlayers = new System.Windows.Forms.Label();
            this.lbxNumberOfPlayers = new System.Windows.Forms.ListBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lbxScorePlayerOne = new System.Windows.Forms.ListBox();
            this.lbxScorePlayerTwo = new System.Windows.Forms.ListBox();
            this.lblPlayerOneScore = new System.Windows.Forms.Label();
            this.lblPlayerTwoScore = new System.Windows.Forms.Label();
            this.lblGameEnder = new System.Windows.Forms.Label();
            this.lbxGameEnder = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxPlayerList
            // 
            this.lbxPlayerList.FormattingEnabled = true;
            this.lbxPlayerList.Location = new System.Drawing.Point(453, 61);
            this.lbxPlayerList.Name = "lbxPlayerList";
            this.lbxPlayerList.Size = new System.Drawing.Size(93, 30);
            this.lbxPlayerList.TabIndex = 1;
            // 
            // lblPlayerList
            // 
            this.lblPlayerList.AutoSize = true;
            this.lblPlayerList.Location = new System.Drawing.Point(450, 45);
            this.lblPlayerList.Name = "lblPlayerList";
            this.lblPlayerList.Size = new System.Drawing.Size(75, 13);
            this.lblPlayerList.TabIndex = 2;
            this.lblPlayerList.Text = "List of Players:";
            // 
            // lblTargetScore
            // 
            this.lblTargetScore.AutoSize = true;
            this.lblTargetScore.Location = new System.Drawing.Point(450, 94);
            this.lblTargetScore.Name = "lblTargetScore";
            this.lblTargetScore.Size = new System.Drawing.Size(72, 13);
            this.lblTargetScore.TabIndex = 3;
            this.lblTargetScore.Text = "Score Target:";
            // 
            // lbxScoreTarget
            // 
            this.lbxScoreTarget.FormattingEnabled = true;
            this.lbxScoreTarget.Location = new System.Drawing.Point(453, 110);
            this.lbxScoreTarget.Name = "lbxScoreTarget";
            this.lbxScoreTarget.Size = new System.Drawing.Size(93, 17);
            this.lbxScoreTarget.TabIndex = 4;
            // 
            // lblPlayersTurn
            // 
            this.lblPlayersTurn.AutoSize = true;
            this.lblPlayersTurn.Location = new System.Drawing.Point(450, 130);
            this.lblPlayersTurn.Name = "lblPlayersTurn";
            this.lblPlayersTurn.Size = new System.Drawing.Size(71, 13);
            this.lblPlayersTurn.TabIndex = 5;
            this.lblPlayersTurn.Text = "Player\'s Turn:";
            // 
            // lbxPlayersTurn
            // 
            this.lbxPlayersTurn.FormattingEnabled = true;
            this.lbxPlayersTurn.Location = new System.Drawing.Point(453, 146);
            this.lbxPlayersTurn.Name = "lbxPlayersTurn";
            this.lbxPlayersTurn.Size = new System.Drawing.Size(93, 17);
            this.lbxPlayersTurn.TabIndex = 6;
            // 
            // lblNumberOfPlayers
            // 
            this.lblNumberOfPlayers.AutoSize = true;
            this.lblNumberOfPlayers.Location = new System.Drawing.Point(450, 9);
            this.lblNumberOfPlayers.Name = "lblNumberOfPlayers";
            this.lblNumberOfPlayers.Size = new System.Drawing.Size(96, 13);
            this.lblNumberOfPlayers.TabIndex = 7;
            this.lblNumberOfPlayers.Text = "Number of Players:";
            // 
            // lbxNumberOfPlayers
            // 
            this.lbxNumberOfPlayers.FormattingEnabled = true;
            this.lbxNumberOfPlayers.Location = new System.Drawing.Point(453, 25);
            this.lbxNumberOfPlayers.Name = "lbxNumberOfPlayers";
            this.lbxNumberOfPlayers.Size = new System.Drawing.Size(93, 17);
            this.lbxNumberOfPlayers.TabIndex = 8;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(12, 322);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(146, 23);
            this.btnGo.TabIndex = 14;
            this.btnGo.Text = "Let\'s Play!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lbxScorePlayerOne
            // 
            this.lbxScorePlayerOne.FormattingEnabled = true;
            this.lbxScorePlayerOne.Location = new System.Drawing.Point(453, 182);
            this.lbxScorePlayerOne.Name = "lbxScorePlayerOne";
            this.lbxScorePlayerOne.Size = new System.Drawing.Size(100, 17);
            this.lbxScorePlayerOne.TabIndex = 15;
            // 
            // lbxScorePlayerTwo
            // 
            this.lbxScorePlayerTwo.FormattingEnabled = true;
            this.lbxScorePlayerTwo.Location = new System.Drawing.Point(453, 215);
            this.lbxScorePlayerTwo.Name = "lbxScorePlayerTwo";
            this.lbxScorePlayerTwo.Size = new System.Drawing.Size(91, 17);
            this.lbxScorePlayerTwo.TabIndex = 16;
            // 
            // lblPlayerOneScore
            // 
            this.lblPlayerOneScore.AutoSize = true;
            this.lblPlayerOneScore.Location = new System.Drawing.Point(450, 166);
            this.lblPlayerOneScore.Name = "lblPlayerOneScore";
            this.lblPlayerOneScore.Size = new System.Drawing.Size(100, 13);
            this.lblPlayerOneScore.TabIndex = 17;
            this.lblPlayerOneScore.Text = "Player One\'s Score:";
            // 
            // lblPlayerTwoScore
            // 
            this.lblPlayerTwoScore.AutoSize = true;
            this.lblPlayerTwoScore.Location = new System.Drawing.Point(450, 199);
            this.lblPlayerTwoScore.Name = "lblPlayerTwoScore";
            this.lblPlayerTwoScore.Size = new System.Drawing.Size(101, 13);
            this.lblPlayerTwoScore.TabIndex = 18;
            this.lblPlayerTwoScore.Text = "Player Two\'s Score:";
            // 
            // lblGameEnder
            // 
            this.lblGameEnder.AutoSize = true;
            this.lblGameEnder.Location = new System.Drawing.Point(161, 312);
            this.lblGameEnder.Name = "lblGameEnder";
            this.lblGameEnder.Size = new System.Drawing.Size(73, 13);
            this.lblGameEnder.TabIndex = 19;
            this.lblGameEnder.Text = "lblGameEnder";
            this.lblGameEnder.Visible = false;
            // 
            // lbxGameEnder
            // 
            this.lbxGameEnder.FormattingEnabled = true;
            this.lbxGameEnder.Location = new System.Drawing.Point(164, 328);
            this.lbxGameEnder.Name = "lbxGameEnder";
            this.lbxGameEnder.Size = new System.Drawing.Size(142, 17);
            this.lbxGameEnder.TabIndex = 20;
            this.lbxGameEnder.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 357);
            this.Controls.Add(this.lbxGameEnder);
            this.Controls.Add(this.lblGameEnder);
            this.Controls.Add(this.lblPlayerTwoScore);
            this.Controls.Add(this.lblPlayerOneScore);
            this.Controls.Add(this.lbxScorePlayerTwo);
            this.Controls.Add(this.lbxScorePlayerOne);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lbxNumberOfPlayers);
            this.Controls.Add(this.lblNumberOfPlayers);
            this.Controls.Add(this.lbxPlayersTurn);
            this.Controls.Add(this.lblPlayersTurn);
            this.Controls.Add(this.lbxScoreTarget);
            this.Controls.Add(this.lblTargetScore);
            this.Controls.Add(this.lblPlayerList);
            this.Controls.Add(this.lbxPlayerList);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblPlayersTurn;
        private System.Windows.Forms.ListBox lbxPlayersTurn;
        private System.Windows.Forms.Label lblNumberOfPlayers;
        private System.Windows.Forms.ListBox lbxNumberOfPlayers;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListBox lbxScorePlayerOne;
        private System.Windows.Forms.ListBox lbxScorePlayerTwo;
        private System.Windows.Forms.Label lblPlayerOneScore;
        private System.Windows.Forms.Label lblPlayerTwoScore;
        private System.Windows.Forms.Label lblGameEnder;
        private System.Windows.Forms.ListBox lbxGameEnder;
    }
}

