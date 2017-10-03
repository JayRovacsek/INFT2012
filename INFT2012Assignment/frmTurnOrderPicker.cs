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

        private void turnOrderPicker_Load(object sender, EventArgs e)
        {

        }

        private string firstPlayer;

        public string turnQuery
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

        private void btnPlayerOneFirst_Click(object sender, EventArgs e)
        {
            firstPlayer = btnPlayerOneFirst.Text;
            this.Dispose();
        }

        private void btnPlayerTwoFirst_Click(object sender, EventArgs e)
        {
            firstPlayer = btnPlayerTwoFirst.Text;
            this.Dispose();
        }

        private void btnRandomOrder_Click(object sender, EventArgs e)
        {
            Random rRand = new Random();
            int iRand = rRand.Next(1, 3);

            switch (iRand)
            {
                case 1:
                    firstPlayer = btnPlayerOneFirst.Text;
                    break;
                case 2:
                    firstPlayer = btnPlayerTwoFirst.Text;
                    break;
            }
            this.Dispose();

        }

        public void labelsToNames(string playerOneName, string playerTwoName)
        {
            btnPlayerOneFirst.Text = playerOneName;
            btnPlayerTwoFirst.Text = playerTwoName;
            return;
        }
    }
}
