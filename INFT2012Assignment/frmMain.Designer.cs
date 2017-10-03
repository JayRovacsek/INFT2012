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
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnOneDie = new System.Windows.Forms.Button();
            this.btnTwoDie = new System.Windows.Forms.Button();
            this.btnFourDie = new System.Windows.Forms.Button();
            this.btnThreeDie = new System.Windows.Forms.Button();
            this.btnFiveDie = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(453, 169);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(93, 23);
            this.btnOptions.TabIndex = 9;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnOneDie
            // 
            this.btnOneDie.Location = new System.Drawing.Point(12, 264);
            this.btnOneDie.Name = "btnOneDie";
            this.btnOneDie.Size = new System.Drawing.Size(70, 23);
            this.btnOneDie.TabIndex = 10;
            this.btnOneDie.Text = "One Dice";
            this.btnOneDie.UseVisualStyleBackColor = true;
            this.btnOneDie.Click += new System.EventHandler(this.btnOneDie_Click);
            // 
            // btnTwoDie
            // 
            this.btnTwoDie.Location = new System.Drawing.Point(88, 264);
            this.btnTwoDie.Name = "btnTwoDie";
            this.btnTwoDie.Size = new System.Drawing.Size(70, 23);
            this.btnTwoDie.TabIndex = 11;
            this.btnTwoDie.Text = "Two Die";
            this.btnTwoDie.UseVisualStyleBackColor = true;
            this.btnTwoDie.Click += new System.EventHandler(this.btnTwoDie_Click);
            // 
            // btnFourDie
            // 
            this.btnFourDie.Location = new System.Drawing.Point(88, 293);
            this.btnFourDie.Name = "btnFourDie";
            this.btnFourDie.Size = new System.Drawing.Size(70, 23);
            this.btnFourDie.TabIndex = 13;
            this.btnFourDie.Text = "Four Die";
            this.btnFourDie.UseVisualStyleBackColor = true;
            this.btnFourDie.Click += new System.EventHandler(this.btnFourDie_Click);
            // 
            // btnThreeDie
            // 
            this.btnThreeDie.Location = new System.Drawing.Point(12, 293);
            this.btnThreeDie.Name = "btnThreeDie";
            this.btnThreeDie.Size = new System.Drawing.Size(70, 23);
            this.btnThreeDie.TabIndex = 12;
            this.btnThreeDie.Text = "Three Die";
            this.btnThreeDie.UseVisualStyleBackColor = true;
            this.btnThreeDie.Click += new System.EventHandler(this.btnThreeDie_Click);
            // 
            // btnFiveDie
            // 
            this.btnFiveDie.Location = new System.Drawing.Point(12, 322);
            this.btnFiveDie.Name = "btnFiveDie";
            this.btnFiveDie.Size = new System.Drawing.Size(146, 23);
            this.btnFiveDie.TabIndex = 14;
            this.btnFiveDie.Text = "Five Die";
            this.btnFiveDie.UseVisualStyleBackColor = true;
            this.btnFiveDie.Click += new System.EventHandler(this.btnFiveDie_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(453, 199);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(93, 69);
            this.listBox1.TabIndex = 15;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 357);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnFiveDie);
            this.Controls.Add(this.btnFourDie);
            this.Controls.Add(this.btnThreeDie);
            this.Controls.Add(this.btnTwoDie);
            this.Controls.Add(this.btnOneDie);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lbxNumberOfPlayers);
            this.Controls.Add(this.lblNumberOfPlayers);
            this.Controls.Add(this.lbxPlayersTurn);
            this.Controls.Add(this.lblPlayersTurn);
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
        private System.Windows.Forms.Label lblPlayersTurn;
        private System.Windows.Forms.ListBox lbxPlayersTurn;
        private System.Windows.Forms.Label lblNumberOfPlayers;
        private System.Windows.Forms.ListBox lbxNumberOfPlayers;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnOneDie;
        private System.Windows.Forms.Button btnTwoDie;
        private System.Windows.Forms.Button btnFourDie;
        private System.Windows.Forms.Button btnThreeDie;
        private System.Windows.Forms.Button btnFiveDie;
        private System.Windows.Forms.ListBox listBox1;
    }
}

