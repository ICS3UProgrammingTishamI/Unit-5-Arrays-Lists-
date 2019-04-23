/*
 * Created by: Tisham Islam
 * Created on: 19/04/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #38 - 2D Arrays
 * This program creates and displays a 2D array to the user's specifications
 * then it adds up all the numbers within it, 
 * before returning the average of the array's numbers
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

namespace _2DArraysTishamI
{
    public partial class frm2DArrays : Form
    {
        public frm2DArrays()
        {
            InitializeComponent();
            txtArray.Enabled = false;
        }

        //random number generator
        Random numGen = new Random();

        //Function: Array Average
        //Input: int[,] intyBoi (A 2D array)
        //Output: String
        //Description: Calculates the average of the numbers within an array,
        //then returns the average in the form of s string
        private string ArrayAverage(int[,] intyBoi)
        {
            //local variables
            int arrayTotal = 0;
            int width;
            int length;
            int genericNum;
            int totalSize;
            double average;

            //set the width, length and total size of the array into variables
            width = intyBoi.GetLength(0);
            length = intyBoi.GetLength(1);
            totalSize = intyBoi.Length;

            //add up all the numbers within the array
            for (int widthCounter = 0; widthCounter < width; widthCounter++)
            {
                for (int lengthCounter = 0; lengthCounter < length; lengthCounter++)
                {
                    genericNum = intyBoi[widthCounter, lengthCounter];
                    arrayTotal += genericNum;
                }
            }

            //calculate the average and then round it off to two decimal places, 
            //before returning it in a string
            average = Math.Round((double)arrayTotal / (double)totalSize, 2);
            return "The average of all the numbers in this array is equal to: " + Convert.ToString(average);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //local variables
            decimal width;
            decimal length;
            string arrayText = "";
            int randomNum;

            //get user length/width
            width = nudWidth.Value;
            length = nudLength.Value;

            //create the array with chosen length/width
            int[,] generic2DArray = new int[(int)width, (int)length];


            for (int widthCounter = 0; widthCounter < width; widthCounter++)
            {
                for (int lengthCounter = 0; lengthCounter < length; lengthCounter++)
                {
                    //generate a number from in between 0 and 9, then add it to the array and the string
                    randomNum = numGen.Next(0, 9 + 1);
                    generic2DArray[widthCounter, lengthCounter] = randomNum;
                    arrayText += " " + randomNum;
                }

                //add a line break to show a new row
                arrayText += Environment.NewLine;
            }

            //enable the textbox and insert the string into it
            txtArray.Text = arrayText;
            txtArray.Enabled = true;
            
            //Display the average of the numbers in the array
            txtArray.Text += Environment.NewLine + ArrayAverage(generic2DArray);
        }
    }
}
