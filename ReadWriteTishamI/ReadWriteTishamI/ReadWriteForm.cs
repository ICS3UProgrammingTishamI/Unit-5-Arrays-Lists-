using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadWriteTishamI
{
    public partial class frmReadWrite : Form
    {
        public frmReadWrite()
        {
            InitializeComponent();
            lblWrote.Hide();
        }

        //Function: String Equalizer
        //Input string str1, string str2
        //Output: bool
        //Desc: Compares strings inputted and sees if they're the same, caps excluded
        private bool StringEqualizer(string str1, string str2)
        {
            //initialize bool to false
            bool equal = false;

            //checks length first for efficiency
            if (str1.Length == str2.Length)
            {
                //convert the strings to upper so that caps are ignored
                //this will not affect the actual strings
                str1 = str1.ToUpper();
                str2 = str2.ToUpper();

                //if they are the same, set the bool to true
                if (str1 == str2)
                {
                    equal = true;
                }
            }

            //return the value
            return equal;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Read the input file into a string array
            string[] file = System.IO.File.ReadAllLines(@"input.txt");

            //array of chars I want gone
            char[] charYeets = new char[] { ' ', '\t' };

            //where my outputs will all go to
            string output = "";

            foreach (string line in file)
            {
                //split the lines of the file into two words
                //there should only be two words in the file
                string[] words = line.Split(charYeets, StringSplitOptions.RemoveEmptyEntries); 

                if (StringEqualizer(words[0], words[1]) == true)
                {
                    //output true, and add line break
                    output += "true\r\n";
                }
                else
                {
                    //output false, and add line break
                    output += "false\r\n";
                }

                //write the output to a new text file
                System.IO.File.WriteAllText(@"output.txt", output);

                lblWrote.Show();
            }

        }
    }
}
