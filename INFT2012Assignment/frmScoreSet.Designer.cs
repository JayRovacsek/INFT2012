namespace INFT2012Assignment
{
    partial class frmScoreSet
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
            this.lblInformation = new System.Windows.Forms.Label();
            this.tbxScoreSet = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(12, 9);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(183, 13);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = "Please choose the score to play until:";
            // 
            // tbxScoreSet
            // 
            this.tbxScoreSet.Location = new System.Drawing.Point(15, 25);
            this.tbxScoreSet.Name = "tbxScoreSet";
            this.tbxScoreSet.Size = new System.Drawing.Size(198, 20);
            this.tbxScoreSet.TabIndex = 1;
            this.tbxScoreSet.Text = "20";
            this.tbxScoreSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 51);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(198, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "All Set!";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmScoreSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 84);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbxScoreSet);
            this.Controls.Add(this.lblInformation);
            this.Name = "frmScoreSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Target Score:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.TextBox tbxScoreSet;
        private System.Windows.Forms.Button btnSubmit;
    }
}