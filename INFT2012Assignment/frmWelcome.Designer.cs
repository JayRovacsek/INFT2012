namespace INFT2012Assignment
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(390, 46);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Welcome to PlusMoins, A game of frustration, and dice. In this game you will roll" +
    " dice in order to achieve a desired score against either an AI opponent or a fri" +
    "end. The rules include;";
            // 
            // lblRules
            // 
            this.lblRules.Location = new System.Drawing.Point(12, 55);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(483, 294);
            this.lblRules.TabIndex = 1;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 352);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(488, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "I got it, let\'s start suffering!";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 386);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblInfo);
            this.Name = "frmWelcome";
            this.Text = "Welcome to PlusMoins!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Button btnStart;
    }
}