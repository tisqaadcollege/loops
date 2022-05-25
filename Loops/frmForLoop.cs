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
    public partial class frmForLoop : Form
    {
        public frmForLoop()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // For Loop

            for(int x = 0; x <= 10; x++)
            {
                lstOutput.Items.Add(x);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear
            lstOutput.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close Form
            Close();
        }
    }
}
