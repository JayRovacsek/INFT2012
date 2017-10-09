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
    public partial class frmTurnOrderPicker : Form
    {
        public frmTurnOrderPicker()
        {
            InitializeComponent();
        }

        private void turnOrderPicker_Load(object sender, EventArgs e)           // Event handler cannot remove without errors.
        {

        }

        private string firstPlayer;                                     

        public string turnQuery                                                 // Method in which to query or set turn
        {
            get
            {
                return firstPlayer;
            }
            set
            {
                firstPlayer = value;
            }
        }

        private void btnPlayerOneFirst_Click(object sender, EventArgs e)        // Method to set player 1 as the "first" turn
        {
            firstPlayer = btnPlayerOneFirst.Text;
            this.Dispose();                                                     // Kill the form when done
        }

        private void btnPlayerTwoFirst_Click(object sender, EventArgs e)        // Method to set second player as "first" turn
        {
            firstPlayer = btnPlayerTwoFirst.Text;
            this.Dispose();
        }

        private void btnRandomOrder_Click(object sender, EventArgs e)           // Method to randomise turn order, just creates a rand; either 1 or 2 then 
        {
            Random rRand = new Random();                                        // Performs a modulus operation on the result.
            int iRand = rRand.Next(1, 3);

            switch (iRand)                                                      // Switch to choose case
            {
                case 1:
                    firstPlayer = btnPlayerOneFirst.Text;                       // Player 1 gets to suffer first
                    break;
                case 2:
                    firstPlayer = btnPlayerTwoFirst.Text;                       // Player 2 gets to suffer first
                    break;
            }
            this.Dispose();                                                     // Kill the form

        }

        public void labelsToNames(string playerOneName, string playerTwoName)   // Set local labels to an appealing name instead of just
        {
            btnPlayerOneFirst.Text = playerOneName;                             // "Player 1" or "Player 2"
            btnPlayerTwoFirst.Text = playerTwoName;
            return;
        }
    }
}
