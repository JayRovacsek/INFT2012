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
                if (sSubmitLabel == "")
                {
                    sSubmitLabel = value;
                }
                else
                {
                    sSubmitLabel = sSubmitLabel + ", " + value;
                }
            }
        }

        #region checkboxes and image-click checking said boxes

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

        private void pbxDieOne_Click(object sender, EventArgs e)
        {
            cbxDieOne.Checked = !cbxDieOne.Checked;
        }

        private void pbxDieTwo_Click(object sender, EventArgs e)
        {
            cbxDieTwo.Checked = !cbxDieTwo.Checked;
        }

        private void pbxDieThree_Click(object sender, EventArgs e)
        {
            cbxDieThree.Checked = !cbxDieThree.Checked;
        }

        private void pbxDieFour_Click(object sender, EventArgs e)
        {
            cbxDieFour.Checked = !cbxDieFour.Checked;
        }

        private void pbxDieFive_Click(object sender, EventArgs e)
        {
            cbxDieFive.Checked = !cbxDieFive.Checked;
        }

        #endregion

        public void RelabelOptions(int[] iDieRolls, string sPlayerName)
        {
            cbxDieOne.Text = "Die: " + Convert.ToString(iDieRolls[0]);
            cbxDieTwo.Text = "Die: " + Convert.ToString(iDieRolls[1]);
            cbxDieThree.Text = "Die: " + Convert.ToString(iDieRolls[2]);
            cbxDieFour.Text = "Die: " + Convert.ToString(iDieRolls[3]);
            cbxDieFive.Text = "Die: " + Convert.ToString(iDieRolls[4]);
            DieCheck(iDieRolls);                                                             // calls the picture box code
            int iTotal = 0;
            for (int i = 0; i < 5; i++)
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
                if (RerolledDieChoice[i] == true)
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

        private void DieCheck(int[] iDieRolls)
        {

            switch (iDieRolls[0])
            {
                case 1:
                    pbxDieOne.Image = Image.FromFile("../dice/one.png");                // sets the pictureboxes to be the corresponding die faces
                    break;                                                              // in "<project>/bin/dice/..." 
                case 2:
                    pbxDieOne.Image = Image.FromFile("../dice/two.png");
                    break;
                case 3:
                    pbxDieOne.Image = Image.FromFile("../dice/three.png");
                    break;
                case 4:
                    pbxDieOne.Image = Image.FromFile("../dice/four.png");
                    break;
                case 5:
                    pbxDieOne.Image = Image.FromFile("../dice/five.png");
                    break;
                case 6:
                    pbxDieOne.Image = Image.FromFile("../dice/six.png");
                    break;
            }
                                                                                        //rest of the picture materialize *magically* when you expand the region
            #region rest of the picture boxes

            switch (iDieRolls[1])
            {
                case 1:
                    pbxDieTwo.Image = Image.FromFile("../dice/one.png");                // sets the pictureboxes to be the corresponding die faces
                    break;                                                              // in "<project>/bin/dice/..." 
                case 2:
                    pbxDieTwo.Image = Image.FromFile("../dice/two.png");
                    break;
                case 3:
                    pbxDieTwo.Image = Image.FromFile("../dice/three.png");
                    break;
                case 4:
                    pbxDieTwo.Image = Image.FromFile("../dice/four.png");
                    break;
                case 5:
                    pbxDieTwo.Image = Image.FromFile("../dice/five.png");
                    break;
                case 6:
                    pbxDieTwo.Image = Image.FromFile("../dice/six.png");
                    break;
            }

            switch (iDieRolls[2])
            {
                case 1:
                    pbxDieThree.Image = Image.FromFile("../dice/one.png");                // sets the pictureboxes to be the corresponding die faces
                    break;                                                              // in "<project>/bin/dice/..." 
                case 2:
                    pbxDieThree.Image = Image.FromFile("../dice/two.png");
                    break;
                case 3:
                    pbxDieThree.Image = Image.FromFile("../dice/three.png");
                    break;
                case 4:
                    pbxDieThree.Image = Image.FromFile("../dice/four.png");
                    break;
                case 5:
                    pbxDieThree.Image = Image.FromFile("../dice/five.png");
                    break;
                case 6:
                    pbxDieThree.Image = Image.FromFile("../dice/six.png");
                    break;
            }

            switch (iDieRolls[3])
            {
                case 1:
                    pbxDieFour.Image = Image.FromFile("../dice/one.png");                // sets the pictureboxes to be the corresponding die faces
                    break;                                                              // in "<project>/bin/dice/..." 
                case 2:
                    pbxDieFour.Image = Image.FromFile("../dice/two.png");
                    break;
                case 3:
                    pbxDieFour.Image = Image.FromFile("../dice/three.png");
                    break;
                case 4:
                    pbxDieFour.Image = Image.FromFile("../dice/four.png");
                    break;
                case 5:
                    pbxDieFour.Image = Image.FromFile("../dice/five.png");
                    break;
                case 6:
                    pbxDieFour.Image = Image.FromFile("../dice/six.png");
                    break;
            }

            switch (iDieRolls[4])
            {
                case 1:
                    pbxDieFive.Image = Image.FromFile("../dice/one.png");                // sets the pictureboxes to be the corresponding die faces
                    break;                                                              // in "<project>/bin/dice/..." 
                case 2:
                    pbxDieFive.Image = Image.FromFile("../dice/two.png");
                    break;
                case 3:
                    pbxDieFive.Image = Image.FromFile("../dice/three.png");
                    break;
                case 4:
                    pbxDieFive.Image = Image.FromFile("../dice/four.png");
                    break;
                case 5:
                    pbxDieFive.Image = Image.FromFile("../dice/five.png");
                    break;
                case 6:
                    pbxDieFive.Image = Image.FromFile("../dice/six.png");
                    break;
            }

            #endregion

        }


    }
}
