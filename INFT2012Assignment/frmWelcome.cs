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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private int playerCount;    //Setup a variable to hold playerCount

        public int playerQuery      //Setup a method to query the playerCount
        {
            get
            {
                return playerCount;
            }
            set
            {
                playerCount = value;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)     //Kill this form
        {
            this.Dispose();                                     
        }

        private void rbnSingle_CheckedChanged(object sender, EventArgs e)   //Check changes, which updates player number
        {
            playerQuery = rbnSingle.Checked ? 1 : 2;                        // Set player number based on the checked option
        }

        private void rbnTwo_CheckedChanged(object sender, EventArgs e)      // Same as above
        {
            playerQuery = rbnTwo.Checked ? 2 : 1;
        }

        private void frmWelcome_Load(object sender, EventArgs e)            // Set player count to 1 to reflect the currently checked option
        {
            playerQuery = 1;
        }
    }
}
