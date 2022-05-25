using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class frmWhile : Form
    {
        public frmWhile()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // While Loop 
            int number = 0; 

            while(number < 10)
            {
                lstOutput.Items.Add(number); 
                number += 1;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear Listbox
            lstOutput.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit Form
            Close();
        }
    }
}
