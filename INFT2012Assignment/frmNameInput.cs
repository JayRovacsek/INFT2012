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
    public partial class frmNameInput : Form
    {
        public frmNameInput()
        {
            InitializeComponent();
        }

        private void frmNameInput_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(tbxName.Text.Equals(null))
            {

            }
            nameQuery = tbxName.Text;
            this.Dispose();
        }

        private string playerName;    //Setup a variable to hold playerCount

        public string nameQuery      //Setup a method to query the playerNames
        {
            get
            {
                return playerName;
            }
            set
            {
                playerName = value;
            }
        }

        private void errorHandle(int iErrorCode)
        {

        }
    }
}
