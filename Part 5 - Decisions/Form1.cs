using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_5___Decisions
{
    public partial class Form1 : Form
    {
        int userAge;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            userAge = Convert.ToInt32(txtInput.Text);
            lblOutput.Text =
        }
    }
}
