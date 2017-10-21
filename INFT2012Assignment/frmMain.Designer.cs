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
            this.pbxDieFive = new System.Windows.Forms.PictureBox();
            this.pbxDieFour = new System.Windows.Forms.PictureBox();
            this.pbxDieThree = new System.Windows.Forms.PictureBox();
            this.pbxDieTwo = new System.Windows.Forms.PictureBox();
            this.pbxDieOne = new System.Windows.Forms.PictureBox();
            this.gbxInformation = new System.Windows.Forms.GroupBox();
            this.gbxDieRolls = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieOne)).BeginInit();
            this.gbxInformation.SuspendLayout();
            this.gbxDieRolls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxPlayerList
            // 
            this.lbxPlayerList.FormattingEnabled = true;
            this.lbxPlayerList.Location = new System.Drawing.Point(6, 62);
            this.lbxPlayerList.Name = "lbxPlayerList";
            this.lbxPlayerList.Size = new System.Drawing.Size(134, 30);
            this.lbxPlayerList.TabIndex = 1;
            // 
            // lblPlayerList
            // 
            this.lblPlayerList.AutoSize = true;
            this.lblPlayerList.Location = new System.Drawing.Point(6, 46);
            this.lblPlayerList.Name = "lblPlayerList";
            this.lblPlayerList.Size = new System.Drawing.Size(75, 13);
            this.lblPlayerList.TabIndex = 2;
            this.lblPlayerList.Text = "List of Players:";
            // 
            // lblTargetScore
            // 
            this.lblTargetScore.AutoSize = true;
            this.lblTargetScore.Location = new System.Drawing.Point(6, 95);
            this.lblTargetScore.Name = "lblTargetScore";
            this.lblTargetScore.Size = new System.Drawing.Size(72, 13);
            this.lblTargetScore.TabIndex = 3;
            this.lblTargetScore.Text = "Score Target:";
            // 
            // lbxScoreTarget
            // 
            this.lbxScoreTarget.FormattingEnabled = true;
            this.lbxScoreTarget.Location = new System.Drawing.Point(6, 111);
            this.lbxScoreTarget.Name = "lbxScoreTarget";
            this.lbxScoreTarget.Size = new System.Drawing.Size(134, 17);
            this.lbxScoreTarget.TabIndex = 4;
            // 
            // lblPlayersTurn
            // 
            this.lblPlayersTurn.AutoSize = true;
            this.lblPlayersTurn.Location = new System.Drawing.Point(6, 131);
            this.lblPlayersTurn.Name = "lblPlayersTurn";
            this.lblPlayersTurn.Size = new System.Drawing.Size(71, 13);
            this.lblPlayersTurn.TabIndex = 5;
            this.lblPlayersTurn.Text = "Player\'s Turn:";
            // 
            // lbxPlayersTurn
            // 
            this.lbxPlayersTurn.FormattingEnabled = true;
            this.lbxPlayersTurn.Location = new System.Drawing.Point(6, 147);
            this.lbxPlayersTurn.Name = "lbxPlayersTurn";
            this.lbxPlayersTurn.Size = new System.Drawing.Size(134, 17);
            this.lbxPlayersTurn.TabIndex = 6;
            // 
            // lblNumberOfPlayers
            // 
            this.lblNumberOfPlayers.AutoSize = true;
            this.lblNumberOfPlayers.Location = new System.Drawing.Point(6, 10);
            this.lblNumberOfPlayers.Name = "lblNumberOfPlayers";
            this.lblNumberOfPlayers.Size = new System.Drawing.Size(96, 13);
            this.lblNumberOfPlayers.TabIndex = 7;
            this.lblNumberOfPlayers.Text = "Number of Players:";
            // 
            // lbxNumberOfPlayers
            // 
            this.lbxNumberOfPlayers.FormattingEnabled = true;
            this.lbxNumberOfPlayers.Location = new System.Drawing.Point(6, 26);
            this.lbxNumberOfPlayers.Name = "lbxNumberOfPlayers";
            this.lbxNumberOfPlayers.Size = new System.Drawing.Size(134, 17);
            this.lbxNumberOfPlayers.TabIndex = 8;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(12, 159);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(544, 130);
            this.btnGo.TabIndex = 14;
            this.btnGo.Text = "Roll the Dice!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lbxScorePlayerOne
            // 
            this.lbxScorePlayerOne.FormattingEnabled = true;
            this.lbxScorePlayerOne.Location = new System.Drawing.Point(6, 183);
            this.lbxScorePlayerOne.Name = "lbxScorePlayerOne";
            this.lbxScorePlayerOne.Size = new System.Drawing.Size(134, 17);
            this.lbxScorePlayerOne.TabIndex = 15;
            // 
            // lbxScorePlayerTwo
            // 
            this.lbxScorePlayerTwo.FormattingEnabled = true;
            this.lbxScorePlayerTwo.Location = new System.Drawing.Point(6, 216);
            this.lbxScorePlayerTwo.Name = "lbxScorePlayerTwo";
            this.lbxScorePlayerTwo.Size = new System.Drawing.Size(134, 17);
            this.lbxScorePlayerTwo.TabIndex = 16;
            // 
            // lblPlayerOneScore
            // 
            this.lblPlayerOneScore.AutoSize = true;
            this.lblPlayerOneScore.Location = new System.Drawing.Point(6, 167);
            this.lblPlayerOneScore.Name = "lblPlayerOneScore";
            this.lblPlayerOneScore.Size = new System.Drawing.Size(100, 13);
            this.lblPlayerOneScore.TabIndex = 17;
            this.lblPlayerOneScore.Text = "Player One\'s Score:";
            // 
            // lblPlayerTwoScore
            // 
            this.lblPlayerTwoScore.AutoSize = true;
            this.lblPlayerTwoScore.Location = new System.Drawing.Point(3, 200);
            this.lblPlayerTwoScore.Name = "lblPlayerTwoScore";
            this.lblPlayerTwoScore.Size = new System.Drawing.Size(101, 13);
            this.lblPlayerTwoScore.TabIndex = 18;
            this.lblPlayerTwoScore.Text = "Player Two\'s Score:";
            // 
            // lblGameEnder
            // 
            this.lblGameEnder.AutoSize = true;
            this.lblGameEnder.Location = new System.Drawing.Point(6, 236);
            this.lblGameEnder.Name = "lblGameEnder";
            this.lblGameEnder.Size = new System.Drawing.Size(73, 13);
            this.lblGameEnder.TabIndex = 19;
            this.lblGameEnder.Text = "lblGameEnder";
            this.lblGameEnder.Visible = false;
            // 
            // lbxGameEnder
            // 
            this.lbxGameEnder.FormattingEnabled = true;
            this.lbxGameEnder.Location = new System.Drawing.Point(6, 252);
            this.lbxGameEnder.Name = "lbxGameEnder";
            this.lbxGameEnder.Size = new System.Drawing.Size(134, 17);
            this.lbxGameEnder.TabIndex = 20;
            this.lbxGameEnder.Visible = false;
            // 
            // pbxDieFive
            // 
            this.pbxDieFive.Location = new System.Drawing.Point(433, 19);
            this.pbxDieFive.Name = "pbxDieFive";
            this.pbxDieFive.Size = new System.Drawing.Size(100, 100);
            this.pbxDieFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDieFive.TabIndex = 25;
            this.pbxDieFive.TabStop = false;
            // 
            // pbxDieFour
            // 
            this.pbxDieFour.Location = new System.Drawing.Point(327, 19);
            this.pbxDieFour.Name = "pbxDieFour";
            this.pbxDieFour.Size = new System.Drawing.Size(100, 100);
            this.pbxDieFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDieFour.TabIndex = 24;
            this.pbxDieFour.TabStop = false;
            // 
            // pbxDieThree
            // 
            this.pbxDieThree.Location = new System.Drawing.Point(221, 19);
            this.pbxDieThree.Name = "pbxDieThree";
            this.pbxDieThree.Size = new System.Drawing.Size(100, 100);
            this.pbxDieThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDieThree.TabIndex = 23;
            this.pbxDieThree.TabStop = false;
            // 
            // pbxDieTwo
            // 
            this.pbxDieTwo.Location = new System.Drawing.Point(115, 19);
            this.pbxDieTwo.Name = "pbxDieTwo";
            this.pbxDieTwo.Size = new System.Drawing.Size(100, 100);
            this.pbxDieTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDieTwo.TabIndex = 22;
            this.pbxDieTwo.TabStop = false;
            // 
            // pbxDieOne
            // 
            this.pbxDieOne.Location = new System.Drawing.Point(9, 19);
            this.pbxDieOne.Name = "pbxDieOne";
            this.pbxDieOne.Size = new System.Drawing.Size(100, 100);
            this.pbxDieOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDieOne.TabIndex = 21;
            this.pbxDieOne.TabStop = false;
            // 
            // gbxInformation
            // 
            this.gbxInformation.BackColor = System.Drawing.SystemColors.Control;
            this.gbxInformation.Controls.Add(this.lbxScoreTarget);
            this.gbxInformation.Controls.Add(this.lbxPlayerList);
            this.gbxInformation.Controls.Add(this.lblPlayerList);
            this.gbxInformation.Controls.Add(this.lblTargetScore);
            this.gbxInformation.Controls.Add(this.lblPlayersTurn);
            this.gbxInformation.Controls.Add(this.lbxPlayersTurn);
            this.gbxInformation.Controls.Add(this.lbxGameEnder);
            this.gbxInformation.Controls.Add(this.lblNumberOfPlayers);
            this.gbxInformation.Controls.Add(this.lblGameEnder);
            this.gbxInformation.Controls.Add(this.lbxNumberOfPlayers);
            this.gbxInformation.Controls.Add(this.lblPlayerTwoScore);
            this.gbxInformation.Controls.Add(this.lbxScorePlayerOne);
            this.gbxInformation.Controls.Add(this.lblPlayerOneScore);
            this.gbxInformation.Controls.Add(this.lbxScorePlayerTwo);
            this.gbxInformation.Location = new System.Drawing.Point(562, 12);
            this.gbxInformation.Name = "gbxInformation";
            this.gbxInformation.Size = new System.Drawing.Size(149, 277);
            this.gbxInformation.TabIndex = 26;
            this.gbxInformation.TabStop = false;
            // 
            // gbxDieRolls
            // 
            this.gbxDieRolls.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDieRolls.Controls.Add(this.pbxDieFive);
            this.gbxDieRolls.Controls.Add(this.pbxDieOne);
            this.gbxDieRolls.Controls.Add(this.pbxDieTwo);
            this.gbxDieRolls.Controls.Add(this.pbxDieThree);
            this.gbxDieRolls.Controls.Add(this.pbxDieFour);
            this.gbxDieRolls.Location = new System.Drawing.Point(12, 12);
            this.gbxDieRolls.Name = "gbxDieRolls";
            this.gbxDieRolls.Size = new System.Drawing.Size(544, 136);
            this.gbxDieRolls.TabIndex = 27;
            this.gbxDieRolls.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 305);
            this.Controls.Add(this.gbxDieRolls);
            this.Controls.Add(this.gbxInformation);
            this.Controls.Add(this.btnGo);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlusMoins";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieOne)).EndInit();
            this.gbxInformation.ResumeLayout(false);
            this.gbxInformation.PerformLayout();
            this.gbxDieRolls.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox pbxDieFive;
        private System.Windows.Forms.PictureBox pbxDieFour;
        private System.Windows.Forms.PictureBox pbxDieThree;
        private System.Windows.Forms.PictureBox pbxDieTwo;
        private System.Windows.Forms.PictureBox pbxDieOne;
        private System.Windows.Forms.GroupBox gbxInformation;
        private System.Windows.Forms.GroupBox gbxDieRolls;
    }
}

