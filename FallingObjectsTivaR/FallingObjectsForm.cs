using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Created by: Tiva Rait
 * Created on: 20-02-2018
 * Created for: ICS3U Programming
 * Assignment #2 - Falling Objects
 * This program Calculates how far an object has fallen after it has been dropped.
*/
namespace FallingObjectsTivaR
{
    public partial class frmFallingObjects : Form
    {
        //Declaring Variables
        double usersTime, usersCliff, usersGravity, finalAnswer;
        //To fix some of the errors
        int errorCheck = 0;

        public frmFallingObjects()
        {
            InitializeComponent();

            
        }

        private void btnGetNumber_Click(object sender, EventArgs e)
        {

            //Variables
            
            int errorCheck = 0;

            try
            {
                usersTime = double.Parse(txtNumberBox.Text);
            }
            catch
            {
                lblDisplayedAnswer.Text = ("You didn't enter a number I'll replace it for you");
                errorCheck = 1;
            }

            //To get the numbers from the text boxes
            if (errorCheck == 0)
            {
                usersTime = double.Parse(txtNumberBox.Text);
                usersCliff = double.Parse(txtCliffBox.Text);
                usersGravity = double.Parse(lblGravity.Text);

                //The calculation
                finalAnswer = (usersCliff - 0.5 * usersGravity * Math.Pow(usersTime, 2));

                //This is the code to round the answer to two decimal places
                finalAnswer = (finalAnswer * 100);
                finalAnswer = (Math.Round(finalAnswer));
                finalAnswer = (finalAnswer / 100);

                lblDisplayedAnswer.Text = Convert.ToString("The height of the object above the ground is " + finalAnswer);

            }
        }


        private void mniExit_Click(object sender, EventArgs e)
        {
            //To close the program
            this.Close();
        }


        private void radMars_CheckedChanged(object sender, EventArgs e)
        {
            //Displays the text that indicates Mars has been selected
            lblGravity.Text = ("3.711");
            lblGravityIs.Text = ("The gravity on Mars is:");

            //Changes the Image to be of Mars
            this.picPlanet.Image = Properties.Resources.Mars;

        }

        private void radEarth_CheckedChanged(object sender, EventArgs e)
        {
            //Displays the text that indicates Earth has been selected
            lblGravity.Text = ("9.81");
            lblGravityIs.Text = ("The gravity on Earth is:");

            //Changes the Image to be of Earth
            this.picPlanet.Image = Properties.Resources.Earth2;
        }
    }
}
