/*
 * Created by: First Last
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Min Value
 * This program creates and displays an array
 * and finds the minimum value in the array
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

namespace MinValueTishamI
{
    public partial class frmMinValue : Form
    {
        //consts and vars
        const int MAX_ARRAY = 10;
        const int MAX_VALUE = 500;
        int[] intyBois = new int[MAX_ARRAY];
        Random numGen = new Random();

        public frmMinValue()
        {
            InitializeComponent();
            lblMinValue.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //variables
            int minValue, counter, randomNum;

            //clear the list
            lstNumbers.Items.Clear();
            
            for (counter = 0; counter < intyBois.Length; counter++)
            {
                //generates a random number, adds it to the list and array
                randomNum = numGen.Next(0, MAX_VALUE);
                intyBois[counter] = randomNum;
                lstNumbers.Items.Add(randomNum);
            }

            //find the min value using the funky ting
            minValue = MinValue(intyBois);

            //display the label and the min value
            lblMinValue.Show();
            lblMinValue.Text = "Min Value: " + minValue;
        }

        //Function: MinValue
        //Input: int[] array
        //Output: int
        //Description: finds the smallest value within an array
        private int MinValue(int[] array)
        {
            //assign the minvalue to the first number in the array
            int minValue = array[0];

            //if any number is smaller than the minValue,
            //then if there's a number in the array that's smaller
            //minValue gets replaced
            foreach (int inty in array)
            {
                if (inty < minValue)
                {
                    minValue = inty;
                }
            }

            return minValue;
        }
    }
}
