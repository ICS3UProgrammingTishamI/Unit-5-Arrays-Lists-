/*
 * Created by: First Last
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Find Max Value
 * This program creates and lists an array of numbers, 
 * and finds the highest value in the array
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

namespace MaxValueTishamI
{
    public partial class frmMaxValue : Form
    {
        //global vars and consts
        const int MAX_ARRAY = 10;
        const int MAX_VALUE = 500;
        int[] intyBoi = new int[MAX_ARRAY];
        Random numGen = new Random();

        public frmMaxValue()
        {
            InitializeComponent();
            lblMaxValue.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //local vars and consts
            int counter, randomNum, maxValue;

            //clear the items within the list
            lstNumbers.Items.Clear();

            for (counter = 0; counter < intyBoi.Length; counter++)
            {
                //generate a random number, then add it to the list and the array
                randomNum = numGen.Next(0, MAX_VALUE + 1);
                lstNumbers.Items.Add(randomNum);
                intyBoi[counter] = randomNum;
            }

            //use the funky ting
            maxValue = MaxValue(intyBoi);

            //show the label, and display the max value
            lblMaxValue.Text = "Max Value: " + maxValue;
            lblMaxValue.Show();
        }

        //Function: MaxValue
        //Input: int[] array
        //Output: int
        //Desc: finds the highest value within an array
        private int MaxValue(int[] array)
        {
            //variables
            int maxValue = array[0];

            //checks all the numbers in the array
            //if it is bigger than the first value
            //change maxValue to be that number
            foreach (int value in array)
            {
                if (value > maxValue)
                {
                    maxValue = value;
                }
            }

            return maxValue;
        }
    }
}
