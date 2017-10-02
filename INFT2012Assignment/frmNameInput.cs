using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            if(tbxName.Text == "Eg: Pikachu")
            {
                nameError(1);
            }
            else if (validateName(tbxName.Text) == false)
            {
                    nameError(2);
            }
            else if (tbxName.Text == "")
            {
                nameError(3);
            }
            else
            {
                nameQuery = tbxName.Text;
                this.Dispose();
            }
        }

        private string playerName;    //Setup a variable to hold playerCount

        private static Boolean validateName(string nameToCheck)
        {
            Regex reg = new Regex(@"^[a-zA-Z0-9\s]*$");
            return reg.IsMatch(nameToCheck);
        }

        private void nameError(int errorCode)
        {
            if(errorCode == 1)
            {
                MessageBox.Show("We really appreciate Pokemon, but hightly doubt your name is that. \r\nPlease re-enter a valid name using only A-Z,0-9 and spaces", "Please enter a valid name");

            }
            else if(errorCode == 2)
            {
                MessageBox.Show("We really appreciate a large charset but prefer you use the more common ones \r\nPlease re-enter a valid name using only A-Z,0-9 and spaces", "Please enter a valid name");
            }
            else if(errorCode == 3)
            {
                MessageBox.Show("We really appreciate anonymity but promise we won't sell you out to the NSA/ASIO etc etc... \r\nPlease re-enter a valid name using only A-Z,0-9 and spaces", "Please enter a valid name");
            }

        }

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
    }
}
