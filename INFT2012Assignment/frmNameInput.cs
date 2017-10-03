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
            string playerName = tbxName.Text;
            string pattern = @"^[a-zA-Z0-9]*$";
            Regex nameRegex = new Regex(pattern, 0);

            switch (playerName)
            {
                case "Eg: Alakazam":
                    errorHandle(1);
                    break;

                case "":
                    errorHandle(2);
                    break;

                default:
                    if (nameRegex.IsMatch(playerName))
                    {
                        nameQuery = tbxName.Text;
                        this.Dispose();
                        break;
                    }
                    else
                    {
                        errorHandle(3);
                        break;
                    }
            }
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
            switch (iErrorCode)
            {
                case 1:         // Default
                    MessageBox.Show("We love Pokemon too, but please enter a valid name", "Name input invalid");
                    break;
                case 2:         // Blank
                    MessageBox.Show("Please enter a name", "Name input invalid");
                    break;
                case 3:         // Invalid Chars
                    MessageBox.Show("We love interesting chars, ", "Name input invalid");
                    break;
            }
        }
    }
}
