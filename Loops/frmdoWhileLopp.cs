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
    public partial class frmdoWhileLopp : Form
    {
        public frmdoWhileLopp()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // DO WHILE LOOP 

            int number = 1000;

            do
            {
                lstOutput.Items.Add(number);
                number++;
            } while (number <= 10);
        }
    }
}
