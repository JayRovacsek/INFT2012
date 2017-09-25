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

        public frmTurnOrderPicker(ListBox lbxPlayerList)
        {
            this.lbxPlayerList = lbxPlayerList;
        }

        private ListBox lbxPlayerList;

        public string turnQuery
        {
            get
            {
                return Convert.ToString(lbxPlayerList.Items);
            }
            set
            {
                if(lbxPlayerList.Items.Count == 2)
                {
                    MessageBox.Show("This will clear all players, are you sure you want to continue?", "Clear Players?");
                    //FIX ME, ABSOLUTELY BROKEN
                }
                lbxPlayerList.Items.Clear();
                lbxPlayerList.Items.Add(value);
            }
        }

        private void btnPlayerOneFirst_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPlayerTwoFirst_Click(object sender, EventArgs e)
        {

        }

        private void turnOrderPicker_Load(object sender, EventArgs e)
        {
            btnPlayerOneFirst.Text = Convert.ToString(lbxPlayerList.Items.IndexOf(1)) + " will go first!";
            btnPlayerTwoFirst.Text = Convert.ToString(lbxPlayerList.Items.IndexOf(1)) + " will go first!";
        }

    }
}
