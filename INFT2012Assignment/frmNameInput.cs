using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;                                   // Also need to use Regex to validate names.

namespace INFT2012Assignment
{
    public partial class frmNameInput : Form
    {
        public frmNameInput()
        {
            InitializeComponent();
        }

        private void frmNameInput_Load(object sender, EventArgs e)      // Accidental event handler, cannot remove without errors.
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)        // Method to handle submission of data.
        {
            string sPlayerNameCandidate = tbxName.Text;                 // Grab input to a variable.
            string sRegexPattern = @"^[a-zA-Z0-9]*$";                   // Setup a pattern for regex later.
            Regex nameRegex = new Regex(sRegexPattern, 0);              // Init regex.

            switch (sPlayerNameCandidate)                               // Switch based on input.
            {
                case "Eg: Alakazam":                                    // Default input, no good.
                    errorHandle(1);                                     // Handle with message.
                    break;

                case "":
                    errorHandle(2);                                     // Blank/No input, no good, handle with message.
                    break;

                default:
                    if (nameRegex.IsMatch(sPlayerNameCandidate))        // Passing the other two fails, check against regex.
                    {
                        NameQuery = tbxName.Text;                       // If passed, set the public to be pulled from frmMain later.
                        this.Dispose();                                 // Kill form.
                        break;                                          // If the form is killed, is this even needed? :D
                    }
                    else
                    {
                        errorHandle(3);                                 // Failing regex check suggest we have a char or undesirable input.
                        break;
                    }
            }
        }

        private string sPlayerName;         //Setup a variable to hold player name.

        public string NameQuery             //Setup a method to query the playerNames.
        {
            get
            {
                return sPlayerName;         
            }
            set
            {
                sPlayerName = value;
            }
        }

        private void errorHandle(int iErrorCode)        // Method to handle invalid entries, and associated messages   
        {
            string sErrorSuggestValid = "\nValid entries include only chars a - z, A - Z and 0 - 9";
            switch (iErrorCode)
            {
                case 1:         // Default
                    MessageBox.Show("We love Pokemon too, but please enter a valid name"+ sErrorSuggestValid, "Name input invalid");
                    break;
                case 2:         // Blank
                    MessageBox.Show("Please enter a name"+sErrorSuggestValid, "Name input invalid");
                    break;
                case 3:         // Invalid Chars
                    MessageBox.Show("We love interesting chars, but please enter a valid name"+ sErrorSuggestValid, "Name input invalid");
                    break;
            }
        }
    }
}
