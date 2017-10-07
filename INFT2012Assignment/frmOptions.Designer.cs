namespace INFT2012Assignment
{
    partial class frmOptions
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
            this.lblPlayerNumberOptions = new System.Windows.Forms.Label();
            this.rbnSinglePlayer = new System.Windows.Forms.RadioButton();
            this.rbnTwoPlayer = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayerNumberOptions
            // 
            this.lblPlayerNumberOptions.AutoSize = true;
            this.lblPlayerNumberOptions.Location = new System.Drawing.Point(13, 13);
            this.lblPlayerNumberOptions.Name = "lblPlayerNumberOptions";
            this.lblPlayerNumberOptions.Size = new System.Drawing.Size(70, 13);
            this.lblPlayerNumberOptions.TabIndex = 0;
            this.lblPlayerNumberOptions.Text = "Player Count:";
            // 
            // rbnSinglePlayer
            // 
            this.rbnSinglePlayer.AutoSize = true;
            this.rbnSinglePlayer.Location = new System.Drawing.Point(16, 29);
            this.rbnSinglePlayer.Name = "rbnSinglePlayer";
            this.rbnSinglePlayer.Size = new System.Drawing.Size(77, 17);
            this.rbnSinglePlayer.TabIndex = 1;
            this.rbnSinglePlayer.TabStop = true;
            this.rbnSinglePlayer.Text = "One Player";
            this.rbnSinglePlayer.UseVisualStyleBackColor = true;
            // 
            // rbnTwoPlayer
            // 
            this.rbnTwoPlayer.AutoSize = true;
            this.rbnTwoPlayer.Location = new System.Drawing.Point(16, 52);
            this.rbnTwoPlayer.Name = "rbnTwoPlayer";
            this.rbnTwoPlayer.Size = new System.Drawing.Size(83, 17);
            this.rbnTwoPlayer.TabIndex = 2;
            this.rbnTwoPlayer.TabStop = true;
            this.rbnTwoPlayer.Text = "Two Players";
            this.rbnTwoPlayer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FIX ME";
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbnTwoPlayer);
            this.Controls.Add(this.rbnSinglePlayer);
            this.Controls.Add(this.lblPlayerNumberOptions);
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerNumberOptions;
        private System.Windows.Forms.RadioButton rbnSinglePlayer;
        private System.Windows.Forms.RadioButton rbnTwoPlayer;
        private System.Windows.Forms.Label label1;
    }
}