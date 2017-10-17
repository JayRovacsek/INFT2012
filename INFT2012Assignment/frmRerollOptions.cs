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
    public partial class frmRerollOptions : Form
    {
        public frmRerollOptions()
        {
            InitializeComponent();
        }

        private bool[] bRerolledDie = new bool[5];

        public bool[] RerolledDieChoice
        {
            get
            {
                return bRerolledDie;
            }
            set
            {
                bRerolledDie = value;
            }
        }

        private bool bSkipped = false;

        public bool CheckIfRerolled
        {
            get
            {
                return bSkipped;
            }
            set
            {
                bSkipped = value;
            }
        }

        private string sSubmitLabel = "";

        public string SetSubmitLabel
        {
            get
            {
                return sSubmitLabel;
            }
            set
            {
                if(sSubmitLabel == "")
                {
                    sSubmitLabel = value;
                }
                else
                {
                    sSubmitLabel = sSubmitLabel + ", " + value;
                }
            }
        }

        private void cbxDieOne_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDieOne.Checked)
            {
                RerolledDieChoice[0] = true;
            }
            else
            {
                RerolledDieChoice[0] = false;
            }
        }

        private void cbxDieTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDieTwo.Checked)
            {
                RerolledDieChoice[1] = true;
            }
            else
            {
                RerolledDieChoice[1] = false;
            }
        }

        private void cbxDieThree_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDieThree.Checked)
            {
                RerolledDieChoice[2] = true;
            }
            else
            {
                RerolledDieChoice[2] = false;
            }
        }

        private void cbxDieFour_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDieFour.Checked)
            {
                RerolledDieChoice[3] = true;
            }
            else
            {
                RerolledDieChoice[3] = false;
            }
        }

        private void cbxDieFive_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDieFive.Checked)
            {
                RerolledDieChoice[4] = true;
            }
            else
            {
                RerolledDieChoice[4] = false;
            }
        }

        public void RelabelOptions(int[] iDieRolls,string sPlayerName)
        {
            cbxDieOne.Text = "Die: " + Convert.ToString(iDieRolls[0]);
            cbxDieTwo.Text = "Die: " + Convert.ToString(iDieRolls[1]);
            cbxDieThree.Text = "Die: " + Convert.ToString(iDieRolls[2]);
            cbxDieFour.Text = "Die: " + Convert.ToString(iDieRolls[3]);
            cbxDieFive.Text = "Die: " + Convert.ToString(iDieRolls[4]);
            int iTotal = 0;
            for(int i = 0; i < 5; i++)
            {
                iTotal = iTotal + iDieRolls[i];
            }
            lblTotal.Text = "Total: " + Convert.ToString(iTotal);
            this.Text = "Would you like to reroll any die " + sPlayerName + "?";
        }

        private bool CheckRerollRequired(bool[] RerolledDieChoice)
        {
            for (int i = 0; i < 5; i++)
            {
                if(RerolledDieChoice[i] == true)
                {
                    CheckIfRerolled = true;
                    return true;
                }
            }
            return false;
        }

        public bool Skipped()
        {
            if (CheckIfRerolled)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int[] DieReroll(int[] iDieRolls)
        {
            bool[] bToRollAgain = RerolledDieChoice;
            Random rDieRand = new Random();
            for (int i = 0; i < 5; i++)
            {
                if (bToRollAgain[i] == true)
                {
                    iDieRolls[i] = rDieRand.Next(1, 7);
                }
            }
            return iDieRolls;
        }

        public int[] DieRerollAI(int[] iDieRolls, bool[] bDieRerollChoice)
        {
            Random rDieRand = new Random();
            for (int i = 0; i < 5; i++)
            {
                if (bDieRerollChoice[i] == true)
                {
                    iDieRolls[i] = rDieRand.Next(1, 7);
                }
            }
            return iDieRolls;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
