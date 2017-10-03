using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//RENAME ALL VARS TO; eg; iInterger or sString etc etc 

namespace INFT2012Assignment
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmWelcome WelcomeForm = new frmWelcome();
            WelcomeForm.ShowDialog();
            int iNumberOfPlayers = WelcomeForm.playerQuery;
            lbxNumberOfPlayers.Items.Add(iNumberOfPlayers);
            setupGame(iNumberOfPlayers);
            Turn playerTurn = new Turn();
        }


        private void setupGame(int iPlayerCount)
        {
            frmScoreSet SetScoreForm = new frmScoreSet();
            SetScoreForm.ShowDialog();
            int scoreTarget = SetScoreForm.queryScoreTarget;
            lbxScoreTarget.Items.Add(scoreTarget);

            dataCheck(iPlayerCount);
            if (iPlayerCount == 1)
            {
                frmNameInput NameInput = new frmNameInput();
                NameInput.ShowDialog();
                dataCheck(NameInput.nameQuery);
                string nameOfPlayer = NameInput.nameQuery;
                lbxPlayerList.Items.Add(nameOfPlayer);
                lbxPlayerList.Items.Add("Evil Robot AI");
            }
            else if(iPlayerCount == 2)
            {
                for(int i = 0; i < 2; i++)
                {
                    frmNameInput NameInput = new frmNameInput();
                    NameInput.ShowDialog();
                    dataCheck(NameInput.nameQuery);
                    string nameOfPlayer = NameInput.nameQuery;
                    lbxPlayerList.Items.Add(nameOfPlayer);
                }
            }
            createLabels(iPlayerCount);
            determineTurnOrder(iPlayerCount);
        }

        private void createLabels(int playerCount)
        {
            if (playerCount == 1)
            {
                this.Text = "Plus Moins Single Player Mode, now with 100% more Evil Robot AI";
            }
            else if (playerCount == 2)
            {
                this.Text = "Plus Moins Two Player Mode";
            }
        }

        private void determineTurnOrder(int playerCount)
        {
            frmTurnOrderPicker TurnPicker = new frmTurnOrderPicker();

            string playerOneName = Convert.ToString(lbxPlayerList.Items[0]);
            string playerTwoName = Convert.ToString(lbxPlayerList.Items[1]);

            TurnPicker.labelsToNames(playerOneName, playerTwoName);
            TurnPicker.ShowDialog();

            int iNumberOfPlayers = Convert.ToInt16(lbxNumberOfPlayers.Items[0]);

            switch (iNumberOfPlayers)
            {
                case 1:
                    MessageBox.Show("Playing one player mode", "");
                    break;
                case 2:
                    MessageBox.Show("Playing two player mode", "");
                    break;
            }

            string firstPlayer = TurnPicker.turnQuery;
            lbxPlayersTurn.Items.Add(firstPlayer);

            //throw new NotImplementedException();
        }

        // Functions to check data with overload style enabled.

        private void dataCheck(int data)
        {
            if (data == -1)
            {
                Application.Exit();
            }
        }
        private void dataCheck(int data, int data2)
        {
            if (data == -1)
            {
                Application.Exit();
            }
            if (data2 == -1)
            {
                Application.Exit();
            }
        }

        private void dataCheck(string data)
        {
            if(data == null)
            {
                Application.Exit();
            }
        }

        private void dataCheck(string data,string data2)
        {
            if (data == null)
            {
                Application.Exit();
            }
            if (data2 == null)
            {
                Application.Exit();
            }
        }

        private void initTurn(string playerName, int iNumDieRolled)
        {
            Turn thisTurn = new Turn();
            thisTurn.performTurn(playerName, iNumDieRolled);
        }

        private void btnOneDie_Click(object sender, EventArgs e)
        {
            initTurn(Convert.ToString(lbxPlayersTurn.Items[0]), 1);
        }

        private void btnTwoDie_Click(object sender, EventArgs e)
        {
            initTurn(Convert.ToString(lbxPlayersTurn.Items[0]), 2);
        }

        private void btnThreeDie_Click(object sender, EventArgs e)
        {
            initTurn(Convert.ToString(lbxPlayersTurn.Items[0]), 3);
        }

        private void btnFourDie_Click(object sender, EventArgs e)
        {
            initTurn(Convert.ToString(lbxPlayersTurn.Items[0]), 4);
        }

        private void btnFiveDie_Click(object sender, EventArgs e)
        {
            initTurn(Convert.ToString(lbxPlayersTurn.Items[0]), 5);
        }
    }
}
