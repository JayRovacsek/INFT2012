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
            InitializeComponent();                                      // Required init of form.
        }

        private void frmMain_Load(object sender, EventArgs e)           // Some stuff we want to do on the load of the form.
        {
            frmWelcome WelcomeForm = new frmWelcome();                  // Show the welcome screen and a set of the rules initially.
            WelcomeForm.ShowDialog();
            int iNumberOfPlayers = WelcomeForm.playerQuery;             // Determine playercount by welcome screen, force user to set.
            lbxNumberOfPlayers.Items.Add(iNumberOfPlayers);             // Modify a number of labels based on player count.
            setupGame(iNumberOfPlayers);                                // Setup game in a single function which allows our form_load to look a little cleaner.
            //Turn playerTurn = new Turn();
            forceFirstTurn();                                           // Force the first turn to occur, as per the rules.
        }


        private void setupGame(int iPlayerCount)                        // Main method for game setup.
        {
            frmScoreSet SetScoreForm = new frmScoreSet();               // Determine target score, used later to check if the game is over.
            SetScoreForm.ShowDialog();                                  
            int scoreTarget = SetScoreForm.queryScoreTarget;            // Hold the variable entered into an easy to use holder for later.
            lbxScoreTarget.Items.Add(scoreTarget);                      

            if (iPlayerCount == 1)                                      // Setup method if we have only one human player
            {
                frmNameInput NameInput = new frmNameInput();            // Form to grab some name data off the user
                NameInput.ShowDialog();                     
                string nameOfPlayer = NameInput.NameQuery;              // Determine player name based on input, regex in this function also should filter
                lbxPlayerList.Items.Add(nameOfPlayer);                  // A number of undesirable chars from being included.
                lbxPlayerList.Items.Add("Evil Robot AI");               // Add the AI name, ofcourse it's evil.
            }
            else if(iPlayerCount == 2)                                  // Setup method for two player use case.
            {
                for(int i = 0; i < 2; i++)                              // Loop twice.
                {
                    frmNameInput NameInput = new frmNameInput();        // Form to grab some name data off the user.
                    NameInput.ShowDialog();
                    string nameOfPlayer = NameInput.NameQuery;          // Determine player name based on input, regex in this function also should filter
                    lbxPlayerList.Items.Add(nameOfPlayer);              // A number of undesirable chars from being included.
                }
            }
            determineTurnOrder(iPlayerCount);                           // Once setup of player names is done, we need to determine turn order.
            createLabels(iPlayerCount);                                 // Create labels based on number of players.
        }

        private void createLabels(int playerCount)
        {
            if (playerCount == 1)                                                               // Code branch for single player mode.
            {
                this.Text = "Plus Moins Single Player Mode, now with 100% more Evil Robot AI";  // Modify main form label, add the Evil AI's presence to 100% more.
            }
            else if (playerCount == 2)                                                          // Code branch for two player mode.
            {
                this.Text = "Plus Moins Two Player Mode";                                       // Modify main form label to not include Evil AI.
            }
            lbxScorePlayerOne.Items.Add(0);                                                     // Set user scores to zero.
            lbxScorePlayerTwo.Items.Add(0);                                                     // Set user scores to zero.
        }

        private void determineTurnOrder(int playerCount)                                // Code branch for determining turn order.
        {
            frmTurnOrderPicker TurnPicker = new frmTurnOrderPicker();                   // Create form to accept input from user.

            string playerOneName = Convert.ToString(lbxPlayerList.Items[0]);            // Take the names we have and pass them to foreign function
            string playerTwoName = Convert.ToString(lbxPlayerList.Items[1]);            // Called TurnPicker.labelsToNames.

            TurnPicker.labelsToNames(playerOneName, playerTwoName);                     // Set some labels to more desirable values, then show the 
            TurnPicker.ShowDialog();                                                    // Relevent form for the user to choose turn order.

            string firstPlayer = TurnPicker.turnQuery;                                  // Set the "First Player" as the one chosen by the user.
            lbxPlayersTurn.Items.Add(firstPlayer);                                      // Add the player to the current turn.
            sNameQueryPlayerOne = firstPlayer;                                          // Set the public string so we can access it externally from this 
                                                                                        // Method.
            if(firstPlayer == Convert.ToString(lbxPlayerList.Items[0]))                 // Now we check if first player is the one stored in the 0'th index in our listbox
            {
                lblPlayerOneScore.Text = lbxPlayerList.Items[0] + "'s Score";           // If they are we modify some labels accordingly
                lblPlayerTwoScore.Text = lbxPlayerList.Items[1] + "'s Score";           // And setup the second player.
                sNameQueryPlayerTwo = Convert.ToString(lbxPlayerList.Items[1]);         // And set the public string for player two's name query to be used externally.
            }

            else
            {
                lblPlayerOneScore.Text = lbxPlayerList.Items[1] + "'s Score";           // Otherwise we must have chose player in the 1st index of the listbox to be
                sNameQueryPlayerTwo = Convert.ToString(lbxPlayerList.Items[0]);         // The first turn, so we set the labels accordingly 
                lblPlayerTwoScore.Text = lbxPlayerList.Items[0] + "'s Score";           // We can assume player two to be in the 0'th index in our listbox
                sNameQueryPlayerOne = Convert.ToString(lbxPlayerList.Items[1]);
            }
        }

        private void forceFirstTurn()                                                   // Force the first turn to occur, as per the rules
        {
            string sFirstPlayer = sNameQueryPlayerOne;                                  // Hold some data locally temporarily in order to make this a little cleaner
            string sSecondPlayer = sNameQueryPlayerTwo;                                 // Give the end-user some info so they're not in the dark also.
            string sPlayerInfo = "As described in the rules, the first turn must use all 5 die\nWe are currently performing ";
            string sMessageBoxTitle = "Performing First Turn";
            MessageBox.Show(sPlayerInfo + sFirstPlayer +"'s turn", sMessageBoxTitle);
            initTurn(5);                                                                // Call a turn with 5 die
            System.Threading.Thread.Sleep(800);                                         // Sleep as to let the user see what's happening instead of just throwing score at them
            MessageBox.Show(sPlayerInfo + sSecondPlayer + "'s turn", sMessageBoxTitle);
            initTurn(5);                                                                // Call another turn 
        }

        private void initTurn(int iNumDieRolled)                                                // Method to perform turns and handle associated data required
        {
            Turn thisTurn = new Turn();
            thisTurn.performTurn(iNumDieRolled, Convert.ToString(lbxPlayersTurn.Items[0]));                                                // Create form and call it, letting it know how many die are chosen.

            if(iTurnNumber == 0)                                                                // If the 1st player's turn, perform score modifications to them
            {
                int iCurrentScore = Convert.ToInt32(lbxScorePlayerOne.Items[0].ToString());     // Grab the current score of player
                iCurrentScore = iCurrentScore + thisTurn.scoreQuery;                            // Add current score and updated score
                lbxScorePlayerOne.Items.Clear();                                                // Clear current score from placeholder
                lbxScorePlayerOne.Items.Add(iCurrentScore);                                     // Place updated score instead into placeholder
            }
            else
            {
                int iCurrentScore = Convert.ToInt32(lbxScorePlayerTwo.Items[0].ToString());     // Otherwise update and perform functions on second player
                iCurrentScore = iCurrentScore + thisTurn.scoreQuery;
                lbxScorePlayerTwo.Items.Clear();
                lbxScorePlayerTwo.Items.Add(iCurrentScore);
            }
            changeTurn();                                                       // Change the turn number as to let the next person have a turn
        }

        private void btnFiveDie_Click(object sender, EventArgs e)               // User starts a turn (Cannot change even name without an error)
        {
            initTurn(5);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmOptions OptionsForm = new frmOptions();
            OptionsForm.ShowDialog();
        }

        private string sPlayerOne;                                  // Setup a variable to hold player name

        private string sPlayerTwo;

        public string sNameQueryPlayerOne                           //Setup a method to query the playerNames
        {
            get
            {
                return sPlayerOne;                                  // Return the otherwise private name
            }
            set
            {
                sPlayerOne = value;                                 // Assign to the private name from a public instance
            }
        }

        public string sNameQueryPlayerTwo                           //Setup a method to query the playerNames
        {
            get
            {
                return sPlayerTwo;                                  // Return the otherwise private name
            }
            set
            {
                sPlayerTwo = value;                                 // Assign to the private name from a public instance
            }
        }

        private int iTurnNumberPrivate = 0;                         // Setup a turn number counter - actually acts more like a bool however

        public int iTurnNumber                                      //Setup a method to query the turn number
        {
            get
            {
                return iTurnNumberPrivate;                          // Return the therwise private var
            }   
            set
            {
                iTurnNumberPrivate = value;                         // Set the value of the private var
            }
        }

        private void changeTurn()                                   // Method to change the turn number
        {
            int iModTurnNumber = iTurnNumber % 2;                   // Modulus operation on the int, check if player 1 or 2 is current 
            switch(iModTurnNumber){
                case 0:                                             // Case that it's player 1
                    iTurnNumber = 1;                                // Juggle the values
                    lbxPlayersTurn.Items.Clear();                   // Clear the old
                    lbxPlayersTurn.Items.Add(sNameQueryPlayerTwo);  // Re-add the value to our listbox container
                    break;
                case 1:                                             // Case that it's player 2
                    iTurnNumber = 0;                                // Set new turn #
                    lbxPlayersTurn.Items.Clear();                   // Kill the old
                    lbxPlayersTurn.Items.Add(sNameQueryPlayerOne);  // Set the new
                    break;
            }
        }
    }
}
