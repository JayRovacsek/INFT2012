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
    public partial class turnOrderPicker : Form
    {
        public turnOrderPicker()
        {
            InitializeComponent();
        }

        private string firstPlayer = "P1";

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
            firstPlayer = "P1";
        }
    }
}
