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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();  //Initalise program 
        }

        private int numberOfPlayers;    // Variable to hold number of players - Maybe better as a bool?

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmWelcome WelcomeForm = new frmWelcome();      // Load up the welcome screen and require action to be taken on it
            WelcomeForm.ShowDialog();                       // ^^
            numberOfPlayers = WelcomeForm.playerQuery;      // Return number of players via public method including getter / setter
            setupGame(numberOfPlayers);                     // Method which requires argument of int for number of players
            createLabels(numberOfPlayers);                  // Redraw and appropriately label relevent fields
            determineTurnOrder();                           // Determine turn orderf

        }

        private void setupGame(int playerCount)                         // Setup Game
        {
            frmScoreSet SetScoreForm = new frmScoreSet();               // Create and load the form
            SetScoreForm.ShowDialog();                                  // ^^
            int scoreTarget = SetScoreForm.queryScoreTarget;            // Query player(s) for score limit, uses a public method in order to access it later
            lbxScoreTarget.Items.Add(scoreTarget);                      // Add the score to our list, allows users a UI element but also an easy way for us to query it later

            dataCheck(playerCount);                                     // Check playerCount data hasn't somehow been broken or misused by the user
            if (playerCount == 1)                                       // If single player branch of code
            {
                frmNameInput NameInput = new frmNameInput();            // Create form for name input, no repetition as only one player
                NameInput.ShowDialog();                                 //
                dataCheck(NameInput.nameQuery);                         // Check Data related to player names
                string nameOfPlayer = NameInput.nameQuery;              // Variable of player name 
                lbxPlayerList.Items.Add(nameOfPlayer);                  // Add that variable to a list, easy to query and view in our form
                lbxPlayerList.Items.Add("Evil Robot AI");               // Add the evil robot AI. Once they learn how to play 
            }
            else                                                        // Two player or more code branch -- extensibility is quite nice, despite not required
            {
                for (int i = 0; i < playerCount; i++)                   // Repeat for n players
                {
                    frmNameInput NameInput = new frmNameInput();        // Create form for name input
                    NameInput.ShowDialog();                             // ^^
                    dataCheck(NameInput.nameQuery);                     // Data check, unexpected stuff ain't nice.
                    string nameOfPlayer = NameInput.nameQuery;          // Hold the data in a variable
                    lbxPlayerList.Items.Add(nameOfPlayer);              // Add variable of playerName to list, easy to view and modify later
                }
            }
        }

        private void createLabels(int playerCount)                      // Dynamic labels, why not?
        {
            if (playerCount == 1)                                       // If we've only got 1 player, create those labels
            {
                this.Text = "Plus Moins Single Player Mode, now with 100% more Evil Robot AI";
            }
            else if (playerCount == 2)                                  // If we've got  players, create relevent labels 
            {
                this.Text = "Plus Moins Two Player Mode, much less Evil Robot AI included";
            }
        }

        private void determineTurnOrder()                                               // Method to determine turn order
        {
            frmTurnOrderPicker TurnPicker = new frmTurnOrderPicker(lbxPlayerList);      // Create the form, pass data related to how many players we have 
            TurnPicker.ShowDialog();                                                    // ^^
        }

        private void dataCheck(int data)                                // 
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

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            if(numberOfPlayers == 1)
            {
                //GAME INCLUDING JUST 1 PLAYER HERE 
            }

            if(numberOfPlayers == 2)
            {
                //GAME INCLUDING JUST 1 PLAYER HERE 
            }
        }
    }
}
