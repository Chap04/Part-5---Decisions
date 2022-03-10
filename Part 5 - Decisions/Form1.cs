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
        //Age Stages
        int userAge;
        int hurricaneCategory;
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

        private void txtHurricaneInput_TextChanged(object sender, EventArgs e)
        {
            //Hurricane Codes - Switch Statements
            
            if (Int32.TryParse(txtHurricaneInput.Text, out hurricaneCategory))
            {
                switch (hurricaneCategory)
                {
                    case 1:
                        lblHurricaneOutput.Text = ("A category 1 hurricane has wind speeds of between 74 and 95 mph (64-82kt or 119-153km/h)");
                        break;
                    case 2:
                        lblHurricaneOutput.Text = ("A category 2 hurricane has wind speeds of between 96 and 110 mph (83-95kt or 154-177km/h)");
                        break;
                    case 3:
                        lblHurricaneOutput.Text = ("A category 3 hurricane has wind speeds of between 111 and 130 mph (96-113kt or 178-209km/h)");
                        break;
                    case 4:
                        lblHurricaneOutput.Text = ("A category 4 hurricane has wind speeds of between 131 and 155 mph (114-135kt or 210-249km/h)");
                        break;
                    case 5:
                        lblHurricaneOutput.Text = ("A category 5 hurricane has wind speeds of 155 mph or greater (136kt or 250km/h)");
                        break;
                    default:
                        lblHurricaneOutput.Text = ("Number is too high");
                        break;
                }
            }
            else lblHurricaneOutput.Text = ("Invalid Response");

            
        }
    }
}
