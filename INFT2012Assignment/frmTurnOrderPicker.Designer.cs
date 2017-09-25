namespace INFT2012Assignment
{
    partial class frmTurnOrderPicker
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
            this.btnPlayerOneFirst = new System.Windows.Forms.Button();
            this.btnPlayerTwoFirst = new System.Windows.Forms.Button();
            this.btnRandomOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(13, 13);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(304, 26);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = "So we\'ve hit a bit of a pickle; turn order.\r\nYou can choose an order or allow for" +
    " a pseudo-random choice:\r\n";
            // 
            // btnPlayerOneFirst
            // 
            this.btnPlayerOneFirst.Location = new System.Drawing.Point(16, 42);
            this.btnPlayerOneFirst.Name = "btnPlayerOneFirst";
            this.btnPlayerOneFirst.Size = new System.Drawing.Size(301, 23);
            this.btnPlayerOneFirst.TabIndex = 1;
            this.btnPlayerOneFirst.Text = "P1F";
            this.btnPlayerOneFirst.UseVisualStyleBackColor = true;
            this.btnPlayerOneFirst.Click += new System.EventHandler(this.btnPlayerOneFirst_Click);
            // 
            // btnPlayerTwoFirst
            // 
            this.btnPlayerTwoFirst.Location = new System.Drawing.Point(16, 71);
            this.btnPlayerTwoFirst.Name = "btnPlayerTwoFirst";
            this.btnPlayerTwoFirst.Size = new System.Drawing.Size(301, 23);
            this.btnPlayerTwoFirst.TabIndex = 2;
            this.btnPlayerTwoFirst.Text = "P2F";
            this.btnPlayerTwoFirst.UseVisualStyleBackColor = true;
            this.btnPlayerTwoFirst.Click += new System.EventHandler(this.btnPlayerTwoFirst_Click);
            // 
            // btnRandomOrder
            // 
            this.btnRandomOrder.Location = new System.Drawing.Point(16, 100);
            this.btnRandomOrder.Name = "btnRandomOrder";
            this.btnRandomOrder.Size = new System.Drawing.Size(301, 23);
            this.btnRandomOrder.TabIndex = 3;
            this.btnRandomOrder.Text = "RANDOM";
            this.btnRandomOrder.UseVisualStyleBackColor = true;
            // 
            // frmTurnOrderPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 136);
            this.Controls.Add(this.btnRandomOrder);
            this.Controls.Add(this.btnPlayerTwoFirst);
            this.Controls.Add(this.btnPlayerOneFirst);
            this.Controls.Add(this.lblInformation);
            this.Name = "frmTurnOrderPicker";
            this.Text = "Turn Order:";
            this.Load += new System.EventHandler(this.turnOrderPicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnPlayerOneFirst;
        private System.Windows.Forms.Button btnPlayerTwoFirst;
        private System.Windows.Forms.Button btnRandomOrder;
    }
}