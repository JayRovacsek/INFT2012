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
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmWelcome WelcomeForm = new frmWelcome();
            WelcomeForm.ShowDialog();
            int numberOfPlayers = WelcomeForm.playerQuery;
            int stubb = 20;
            setupGame(numberOfPlayers, stubb);
            createLabels(numberOfPlayers);
            determineTurnOrder(numberOfPlayers);

        }

        private string playerName;

        public string nameQuery
        {
            get
            {
                return Convert.ToString(lbxPlayerList.Items);
            }

        }

        private void setupGame(int playerCount,int scoreTarget)
        {
            dataCheck(playerCount, scoreTarget);
            if (playerCount == 1)
            {
                frmNameInput NameInput = new frmNameInput();
                NameInput.ShowDialog();
                dataCheck(NameInput.nameQuery);
                string nameOfPlayer = NameInput.nameQuery;
                lbxPlayerList.Items.Add(nameOfPlayer);
                lbxPlayerList.Items.Add("Evil Robot AI");
            }
            else
            {
                for (int i = 0; i < playerCount; i++)
                {
                    frmNameInput NameInput = new frmNameInput();
                    NameInput.ShowDialog();
                    dataCheck(NameInput.nameQuery);
                    string nameOfPlayer = NameInput.nameQuery;
                    lbxPlayerList.Items.Add(nameOfPlayer);
                }
            }
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

        }

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
    }
}
