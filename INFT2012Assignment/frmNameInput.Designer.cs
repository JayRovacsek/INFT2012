namespace INFT2012Assignment
{
    partial class frmNameInput
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(12, 9);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(121, 13);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = "Please enter your name:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 51);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(189, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "That\'s me, I promise!";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(15, 25);
            this.tbxName.MaxLength = 50;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(189, 20);
            this.tbxName.TabIndex = 2;
            this.tbxName.Text = "Eg: Alakazam";
            // 
            // frmNameInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 85);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblInformation);
            this.Name = "frmNameInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name Input:";
            this.Load += new System.EventHandler(this.frmNameInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbxName;
    }
}