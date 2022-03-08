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
            if (Int32.TryParse(txtInput.Text, out userAge))
            {
                if (userAge <= 5)
                {
                    lblOutput.Text = ("Toddler");
                }
                else if (userAge > 5 && userAge <= 10)
                {
                    lblOutput.Text = ("Child");
                }
                else if (userAge > 10 && userAge <= 12)
                {
                    lblOutput.Text = ("Preteen");
                }
                else if (userAge > 12 && userAge <= 18)
                {
                    lblOutput.Text = ("Teenager");
                }
                else if (userAge > 18)
                {
                    lblOutput.Text = ("Adult");
                }
                else if (userAge < 0)
                {
                    lblOutput.Text = ("Error");
                }
            }
            else
            {
                lblOutput.Text = ("Error! Non-numerical input not accepted");
            }

        

        }
    }
}
