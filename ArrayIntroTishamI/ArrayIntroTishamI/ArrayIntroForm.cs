/*
 * Created by: Tisham Islam
 * Created on: 21/04/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - Introduction to Arrays
 * This program creates an array of 10 numbers
 * and displays the average of all the numbers
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayIntroTishamI
{
    public partial class frmArrayIntro : Form
    {
        //global vars and consts
        const int MAX_ARRAY = 10;
        Random numGen = new Random();

        //make a new array
        int[] numArray = new int[MAX_ARRAY];

        public frmArrayIntro()
        {
            InitializeComponent();
            lblAverage.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //local variables
            int counter;
            int randomNum;
            
            //clear the listbox
            lstNumbers.Items.Clear();

            for (counter = 0; counter < numArray.Length; counter++)
            {
                //generate random number and add it to the array and the list
                randomNum = numGen.Next(0, 9 + 1);
                numArray[counter] = randomNum;
                lstNumbers.Items.Add(randomNum);

                //Hide the previous average
                lblAverage.Hide();

                //refresh the form
                this.Refresh();
            }

        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            //local variables
            double average;
            double sum = 0;
            int counter;

            //calculate the sum of the numebrs in the array
            for (counter = 0; counter < numArray.Length; counter++)
            {
                sum += numArray[counter];
            }

            //calculate and display the average
            average = sum / numArray.Length;
            lblAverage.Text = "Average: " + average;
            lblAverage.Show();
        }
    }
}
