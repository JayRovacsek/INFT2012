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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                queryScoreTarget = Convert.ToInt32(tbxScoreSet.Text);
                if (queryScoreTarget > 0)
                {
                    this.Dispose();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid score to play to", "Invalid Imput");
            }
        }

        private int scoreTarget;    //Setup a variable to hold scoreTarget

        public int queryScoreTarget      //Setup a method to query the scoreTarget
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
