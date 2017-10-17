namespace INFT2012Assignment
{
    partial class frmRerollOptions
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
            this.cbxDieOne = new System.Windows.Forms.CheckBox();
            this.cbxDieTwo = new System.Windows.Forms.CheckBox();
            this.cbxDieThree = new System.Windows.Forms.CheckBox();
            this.cbxDieFour = new System.Windows.Forms.CheckBox();
            this.cbxDieFive = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pbxDieOne = new System.Windows.Forms.PictureBox();
            this.pbxDieTwo = new System.Windows.Forms.PictureBox();
            this.pbxDieThree = new System.Windows.Forms.PictureBox();
            this.pbxDieFour = new System.Windows.Forms.PictureBox();
            this.pbxDieFive = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieFive)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxDieOne
            // 
            this.cbxDieOne.AutoSize = true;
            this.cbxDieOne.Location = new System.Drawing.Point(47, 142);
            this.cbxDieOne.Name = "cbxDieOne";
            this.cbxDieOne.Size = new System.Drawing.Size(64, 17);
            this.cbxDieOne.TabIndex = 0;
            this.cbxDieOne.Text = "Die 1: X";
            this.cbxDieOne.UseVisualStyleBackColor = true;
            this.cbxDieOne.CheckedChanged += new System.EventHandler(this.cbxDieOne_CheckedChanged);
            // 
            // cbxDieTwo
            // 
            this.cbxDieTwo.AutoSize = true;
            this.cbxDieTwo.Location = new System.Drawing.Point(117, 142);
            this.cbxDieTwo.Name = "cbxDieTwo";
            this.cbxDieTwo.Size = new System.Drawing.Size(64, 17);
            this.cbxDieTwo.TabIndex = 1;
            this.cbxDieTwo.Text = "Die 2: X";
            this.cbxDieTwo.UseVisualStyleBackColor = true;
            this.cbxDieTwo.CheckedChanged += new System.EventHandler(this.cbxDieTwo_CheckedChanged);
            // 
            // cbxDieThree
            // 
            this.cbxDieThree.AutoSize = true;
            this.cbxDieThree.Location = new System.Drawing.Point(187, 142);
            this.cbxDieThree.Name = "cbxDieThree";
            this.cbxDieThree.Size = new System.Drawing.Size(64, 17);
            this.cbxDieThree.TabIndex = 2;
            this.cbxDieThree.Text = "Die 3: X";
            this.cbxDieThree.UseVisualStyleBackColor = true;
            this.cbxDieThree.CheckedChanged += new System.EventHandler(this.cbxDieThree_CheckedChanged);
            // 
            // cbxDieFour
            // 
            this.cbxDieFour.AutoSize = true;
            this.cbxDieFour.Location = new System.Drawing.Point(257, 142);
            this.cbxDieFour.Name = "cbxDieFour";
            this.cbxDieFour.Size = new System.Drawing.Size(64, 17);
            this.cbxDieFour.TabIndex = 3;
            this.cbxDieFour.Text = "Die 4: X";
            this.cbxDieFour.UseVisualStyleBackColor = true;
            this.cbxDieFour.CheckedChanged += new System.EventHandler(this.cbxDieFour_CheckedChanged);
            // 
            // cbxDieFive
            // 
            this.cbxDieFive.AutoSize = true;
            this.cbxDieFive.Location = new System.Drawing.Point(327, 142);
            this.cbxDieFive.Name = "cbxDieFive";
            this.cbxDieFive.Size = new System.Drawing.Size(64, 17);
            this.cbxDieFive.TabIndex = 4;
            this.cbxDieFive.Text = "Die 5: X";
            this.cbxDieFive.UseVisualStyleBackColor = true;
            this.cbxDieFive.CheckedChanged += new System.EventHandler(this.cbxDieFive_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "You now have the option to reroll any die of your choice, please choose which die" +
    " you would like to reroll or skip";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 194);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(400, 31);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "All set, Let\'s go!";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pbxDieOne
            // 
            this.pbxDieOne.Location = new System.Drawing.Point(47, 69);
            this.pbxDieOne.Name = "pbxDieOne";
            this.pbxDieOne.Size = new System.Drawing.Size(54, 50);
            this.pbxDieOne.TabIndex = 7;
            this.pbxDieOne.TabStop = false;
            // 
            // pbxDieTwo
            // 
            this.pbxDieTwo.Location = new System.Drawing.Point(117, 69);
            this.pbxDieTwo.Name = "pbxDieTwo";
            this.pbxDieTwo.Size = new System.Drawing.Size(54, 50);
            this.pbxDieTwo.TabIndex = 8;
            this.pbxDieTwo.TabStop = false;
            // 
            // pbxDieThree
            // 
            this.pbxDieThree.Location = new System.Drawing.Point(187, 69);
            this.pbxDieThree.Name = "pbxDieThree";
            this.pbxDieThree.Size = new System.Drawing.Size(54, 50);
            this.pbxDieThree.TabIndex = 9;
            this.pbxDieThree.TabStop = false;
            // 
            // pbxDieFour
            // 
            this.pbxDieFour.Location = new System.Drawing.Point(257, 69);
            this.pbxDieFour.Name = "pbxDieFour";
            this.pbxDieFour.Size = new System.Drawing.Size(54, 50);
            this.pbxDieFour.TabIndex = 10;
            this.pbxDieFour.TabStop = false;
            // 
            // pbxDieFive
            // 
            this.pbxDieFive.Location = new System.Drawing.Point(327, 69);
            this.pbxDieFive.Name = "pbxDieFive";
            this.pbxDieFive.Size = new System.Drawing.Size(54, 50);
            this.pbxDieFive.TabIndex = 11;
            this.pbxDieFive.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(195, 162);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total: ";
            // 
            // frmRerollOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 237);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.pbxDieFive);
            this.Controls.Add(this.pbxDieFour);
            this.Controls.Add(this.pbxDieThree);
            this.Controls.Add(this.pbxDieTwo);
            this.Controls.Add(this.pbxDieOne);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDieFive);
            this.Controls.Add(this.cbxDieFour);
            this.Controls.Add(this.cbxDieThree);
            this.Controls.Add(this.cbxDieTwo);
            this.Controls.Add(this.cbxDieOne);
            this.Name = "frmRerollOptions";
            this.Text = "Reroll any die?";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDieFive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxDieOne;
        private System.Windows.Forms.CheckBox cbxDieTwo;
        private System.Windows.Forms.CheckBox cbxDieThree;
        private System.Windows.Forms.CheckBox cbxDieFour;
        private System.Windows.Forms.CheckBox cbxDieFive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pbxDieOne;
        private System.Windows.Forms.PictureBox pbxDieTwo;
        private System.Windows.Forms.PictureBox pbxDieThree;
        private System.Windows.Forms.PictureBox pbxDieFour;
        private System.Windows.Forms.PictureBox pbxDieFive;
        private System.Windows.Forms.Label lblTotal;
    }
}