using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFT2012Assignment
{
    public partial class frmScoreSet : Form
    {
        public frmScoreSet()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)                            // Method to attempt acceptance of data, try/catch used to avoid errors.
        {
            try
            {
                queryScoreTarget = Convert.ToInt32(tbxScoreSet.Text);                       // Convert to int, check if greater than 0.
                if (queryScoreTarget > 0)
                {
                    this.Dispose();
                }
                else
                {
                    queryScoreTarget = queryScoreTarget * -1;                               // If negative, just fix it to be positive :)
                    this.Dispose();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid score to play to", "Invalid Imput");  // Maybe text or non convertable chars? Shall suggest they fix that.
            }
        }

        private int scoreTarget;            //Setup a variable to hold scoreTarget

        public int queryScoreTarget         //Setup a method to query the scoreTarget
        {
            get
            {
                return scoreTarget;
            }
            set
            {
                scoreTarget = value;
            }
        }
    }
}
