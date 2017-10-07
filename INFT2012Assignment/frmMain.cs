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
            //Turn playerTurn = new Turn();
            forceFirstTurn();
        }


        private void setupGame(int iPlayerCount)
        {
            frmScoreSet SetScoreForm = new frmScoreSet();
            SetScoreForm.ShowDialog();
            int scoreTarget = SetScoreForm.queryScoreTarget;
            lbxScoreTarget.Items.Add(scoreTarget);

            //dataCheck(iPlayerCount);
            if (iPlayerCount == 1)
            {
                frmNameInput NameInput = new frmNameInput();
                NameInput.ShowDialog();
                //dataCheck(NameInput.nameQuery);
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
                    //dataCheck(NameInput.nameQuery);
                    string nameOfPlayer = NameInput.nameQuery;
                    lbxPlayerList.Items.Add(nameOfPlayer);
                }
            }
            determineTurnOrder(iPlayerCount);
            createLabels(iPlayerCount);
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
            lbxScorePlayerOne.Items.Add(0);
            lbxScorePlayerTwo.Items.Add(0);
        }

        private void determineTurnOrder(int playerCount)
        {
            frmTurnOrderPicker TurnPicker = new frmTurnOrderPicker();

            string playerOneName = Convert.ToString(lbxPlayerList.Items[0]);
            string playerTwoName = Convert.ToString(lbxPlayerList.Items[1]);

            TurnPicker.labelsToNames(playerOneName, playerTwoName);
            TurnPicker.ShowDialog();

            int iNumberOfPlayers = Convert.ToInt16(lbxNumberOfPlayers.Items[0]);

            //switch (iNumberOfPlayers)
            //{
            //    case 1:
            //        MessageBox.Show("Playing one player mode", "");
            //        break;
            //    case 2:
            //        MessageBox.Show("Playing two player mode", "");
            //        break;
            //}

            string firstPlayer = TurnPicker.turnQuery;
            lbxPlayersTurn.Items.Add(firstPlayer);
            sNameQueryPlayerOne = firstPlayer;

            if(firstPlayer == Convert.ToString(lbxPlayerList.Items[0]))
            {
                lblPlayerOneScore.Text = lbxPlayerList.Items[0] + "'s Score";
                lblPlayerTwoScore.Text = lbxPlayerList.Items[1] + "'s Score";
                sNameQueryPlayerTwo = Convert.ToString(lbxPlayerList.Items[1]);
            }

            else
            {
                lblPlayerOneScore.Text = lbxPlayerList.Items[1] + "'s Score";
                sNameQueryPlayerTwo = Convert.ToString(lbxPlayerList.Items[0]);
                lblPlayerTwoScore.Text = lbxPlayerList.Items[0] + "'s Score";
                sNameQueryPlayerOne = Convert.ToString(lbxPlayerList.Items[1]);
            }
        }

        private void forceFirstTurn()
        {
            string sFirstPlayer = sNameQueryPlayerOne;
            string sSecondPlayer = sNameQueryPlayerTwo;
            MessageBox.Show("As described in the rules, the first turn must use all 5 die/nWe are currently performing "+ sFirstPlayer +"'s turn", "Performing First Turn");
            initTurn(5);
            System.Threading.Thread.Sleep(200);
            MessageBox.Show("As described in the rules, the first turn must use all 5 die/nWe are currently performing " + sSecondPlayer + "'s turn", "Performing First Turn");
            initTurn(5);
        }
        // Functions to check data with overload style enabled.

        //private void dataCheck(int data)
        //{
        //    if (data == -1)
        //    {
        //        Application.Exit();
        //    }
        //}
        //private void dataCheck(int data, int data2)
        //{
        //    if (data == -1)
        //    {
        //        Application.Exit();
        //    }
        //    if (data2 == -1)
        //    {
        //        Application.Exit();
        //    }
        //}

        //private void dataCheck(string data)
        //{
        //    if(data == null)
        //    {
        //        Application.Exit();
        //    }
        //}

        //private void dataCheck(string data,string data2)
        //{
        //    if (data == null)
        //    {
        //        Application.Exit();
        //    }
        //    if (data2 == null)
        //    {
        //        Application.Exit();
        //    }
        //}

        private void initTurn(int iNumDieRolled)
        {
            Turn thisTurn = new Turn();
            thisTurn.performTurn(iNumDieRolled);

            if(iTurnNumber == 0)
            {
                int iCurrentScore = Convert.ToInt32(lbxScorePlayerOne.Items[0].ToString());
                iCurrentScore = iCurrentScore + thisTurn.scoreQuery;
                MessageBox.Show(Convert.ToString(thisTurn.scoreQuery), "");
                lbxScorePlayerOne.Items.Clear();
                lbxScorePlayerOne.Items.Add(iCurrentScore);
            }
            else
            {
                int iCurrentScore = Convert.ToInt32(lbxScorePlayerTwo.Items[0].ToString());
                iCurrentScore = iCurrentScore + thisTurn.scoreQuery;
                MessageBox.Show(Convert.ToString(thisTurn.scoreQuery),"");
                lbxScorePlayerTwo.Items.Clear();
                lbxScorePlayerTwo.Items.Add(iCurrentScore);
            }
            changeTurn();
        }

        private void btnOneDie_Click(object sender, EventArgs e)
        {
            initTurn(1);
        }

        private void btnTwoDie_Click(object sender, EventArgs e)
        {
            initTurn(2);
        }

        private void btnThreeDie_Click(object sender, EventArgs e)
        {
            initTurn(3);
        }

        private void btnFourDie_Click(object sender, EventArgs e)
        {
            initTurn(4);
        }

        private void btnFiveDie_Click(object sender, EventArgs e)
        {
            initTurn(5);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmOptions OptionsForm = new frmOptions();
            OptionsForm.ShowDialog();
        }

        private string sPlayerOne;    //Setup a variable to hold playerCount
        private string sPlayerTwo;    //Setup a variable to hold playerCount

        public string sNameQueryPlayerOne      //Setup a method to query the playerNames
        {
            get
            {
                return sPlayerOne;
            }
            set
            {
                sPlayerOne = value;
            }
        }

        public string sNameQueryPlayerTwo      //Setup a method to query the playerNames
        {
            get
            {
                return sPlayerTwo;
            }
            set
            {
                sPlayerTwo = value;
            }
        }

        private int iTurnNumberPrivate = 0;

        public int iTurnNumber      //Setup a method to query the playerNames
        {
            get
            {
                return iTurnNumberPrivate;
            }
            set
            {
                iTurnNumberPrivate = value;
            }
        }

        private void changeTurn()
        {
            int iModTurnNumber = iTurnNumber % 2;
            switch(iModTurnNumber){
                case 0:
                    iTurnNumber = 1;
                    lbxPlayersTurn.Items.Clear();
                    lbxPlayersTurn.Items.Add(sNameQueryPlayerTwo);
                    break;
                case 1:
                    iTurnNumber = 0;
                    lbxPlayersTurn.Items.Clear();
                    lbxPlayersTurn.Items.Add(sNameQueryPlayerOne);
                    break;
            }
        }
    }
}
