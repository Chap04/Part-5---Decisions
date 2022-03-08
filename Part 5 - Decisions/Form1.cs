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


            //Hurricane Codes - Switch Statements
            //https://www.programiz.com/csharp-programming/switch-statement
            // Use this to figure out Switch statements
            //Replace "Console.Readline" with "int Ex = Convert.ToInt32(txtEx.Text);"


            // char ch;
            //Console.WriteLine("Enter an alphabet");
            //ch = Convert.ToChar(Console.ReadLine());

            //switch (Char.ToLower(ch))
            //{
                //case 'a':
                    //Console.WriteLine("Vowel");
                    //break;
                //case 'e':
                    //Console.WriteLine("Vowel");
                    //break;
                //case 'i':
                    //Console.WriteLine("Vowel");
                    //break;
                //case 'o':
                    //Console.WriteLine("Vowel");
                    //break;
                //case 'u':
                    //Console.WriteLine("Vowel");
                   // break;
                //default:
                    //Console.WriteLine("Not a vowel");
                    //break;
            //}

        }

    }
}
