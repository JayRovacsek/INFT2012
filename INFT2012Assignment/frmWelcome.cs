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
            if (rbnSingle.Checked)
            {
                playerQuery = 1;
            }
            else
            {
                playerQuery = 2;
            }
        }

        private void rbnTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnTwo.Checked)
            {
                playerQuery = 2;
            }
            else
            {
                playerQuery = 1;
            }
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            playerQuery = 1;
        }
    }
}
