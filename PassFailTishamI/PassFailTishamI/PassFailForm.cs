/*
 * Created by: Tisham Islam
 * Created on: 08/05/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #41 - Pass Fail
 * This program parses three data files and solves the "Pass Fail" Problem,
 * taken from the programming cometition
 * It also can create and solve problems by itself (extra)
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
using System.IO;

namespace PassFailTishamI
{
    public partial class frmPassFail : Form
    {
        //variables
        string[] studentMarks = new string[3];
        string inputName, outputName;
        float weightT, weightA, weightP, weightQ;
        float markT, markA, markP, markQ;
        float average;
        int numStudents;
        int numPassed;
        int counterA, counterB;


        //vars for fun
        Random numGen = new Random();
        const int MAX_STUDENTS = 50;

        public frmPassFail()
        {
            InitializeComponent();
        }

        private void btnCreateAndParse_Click(object sender, EventArgs e)
        {
            //turn inputname to the string returned by DataCreate()
            //output name is changed in the function
            inputName = DataCreate();

            //create an output file with the answers
            PassFail(inputName, outputName);
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            PassFail("DATA10.txt", "DATA10_Output.txt");
            PassFail("DATA11.txt", "DATA11_Output.txt");
            PassFail("DATA12.txt", "DATA12_Output.txt");
        }

        #region Pass Fail Function
        private void PassFail(string filePath, string outputFile)
        { 
            //read the file into an array of strings, and reset countA to 0
            string[] lines = File.ReadAllLines(filePath);
            counterA = 0;

            //writing to this file
            using (StreamWriter file = new StreamWriter(outputFile))
            {
                //loops through every part of the txt file
                while (counterA < lines.Length)
                {
                    //reset passed students to 0
                    numPassed = 0;

                    //read the first line for main info
                    string line1 = lines[counterA];

                    //split the weights from the first line for this class
                    string[] weights = line1.Split(' ');

                    //asign the weights
                    weightT = float.Parse(weights[0]);
                    weightA = float.Parse(weights[1]);
                    weightP = float.Parse(weights[2]);
                    weightQ = float.Parse(weights[3]);

                    //assign the total number of students
                    numStudents = int.Parse(lines[counterA + 1]);

                    for (counterB = counterA + 2; counterB < counterA + 2 + numStudents; counterB++)
                    {
                        //find the marks for the current student 
                        studentMarks = lines[counterB].Split(' ');

                        //assign the marks
                        markT = float.Parse(studentMarks[0]);
                        markA = float.Parse(studentMarks[1]);
                        markP = float.Parse(studentMarks[2]);
                        markQ = float.Parse(studentMarks[3]);

                        //calculate averages into a percentage grade
                        average = ((markT * weightT) + (markA * weightA)
                            + (markP * weightP) + (markQ * weightQ)) / 100;

                        //if the students pass, increment numPass
                        if (average >= 50)
                        {
                            numPassed++;
                        }
                    }

                    //write the number of passes into the output file
                    file.WriteLine("Number of Passes = " + numPassed);

                    //re-assign counterA, as these lines no longer have any use
                    counterA = counterB;
                }
            }
        }
        #endregion

        #region Data Create function
        private string DataCreate()
        {
            //create the file names, using a set of three random numbers
            string fileName = "DATA";
            fileName += 
                Convert.ToString(numGen.Next(0, 9 + 1)) +
                Convert.ToString(numGen.Next(0, 9 + 1)) +
                Convert.ToString(numGen.Next(0, 9 + 1));
            outputName = fileName + "_Output.txt";
            fileName += ".txt";

            //writing to this file
            using (StreamWriter file = new StreamWriter(fileName))
            {
                for (int counterC = 0; counterC < 10; counterC++)
                {
                    //generate less than random numbers for weights
                    weightT = numGen.Next(30, 40);
                    weightA = numGen.Next(10, 20);
                    weightP = numGen.Next(20, 30);
                    weightQ = 100 - (weightT + weightA + weightP);

                    //write the weights into one line
                    file.WriteLine(weightT + " " + weightA + " " + weightP + " " + weightQ);

                    //generate and then write the number of students
                    numStudents = numGen.Next(1, MAX_STUDENTS);
                    file.WriteLine(numStudents);

                    //for every student in this iteration
                    for (int counterD = 0; counterD < numStudents; counterD++)
                    {
                        //create four marks, then line break
                        for (int counterE = 0; counterE < 4; counterE++)
                            file.Write(numGen.Next(0, 100) + " ");
                        file.Write("\r\n");
                    }
                }
            }
            return fileName;
        }
        #endregion
    }
}
