using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListsTishamI
{
    public partial class frmLists : Form
    {
        List<int> listMarks = new List<int>();

        public frmLists()
        {
            InitializeComponent();
            lblAverage.Hide();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //declare local variables
            int userMark = -1;

            //convert value in textbox into int
            try
            {
                userMark = int.Parse(txtMarks.Text);
            }
            catch (Exception parseError)
            {
                Console.WriteLine("An error occurred", parseError);
                return;
            }

            //check if the user entered a number between 0 and 100
            if ( userMark >= 0 && userMark <= 100)
            {
                //add your mark to the list and listbox
                lstMarks.Items.Add(userMark);
                listMarks.Add(userMark);
                lblAverage.Text = "Average: " + ListAverage(ref listMarks);
            }
        }

        //Function: List Average
        //Input: ref list
        //Ouput: int
        //Returns the average number of a inty list's contents
        double ListAverage(ref List<int> listyMan)
        {
            //var 
            double listAverage = 0;

            //for every int in the list, add them up to listAverage 
            for (int averageCount = 0; averageCount < listyMan.Count(); averageCount++)
            {
                listAverage += listyMan[averageCount];
            }

            //calculate the list's average number, round it, and return it to call
            listAverage /= listyMan.Count();
            Math.Round(listAverage, 2);
            return listAverage;
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            lblAverage.Show();
        }
    }
}
