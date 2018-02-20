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
 * This program...
*/
namespace FallingObjectsTivaR
{
    public partial class frmFallingObjects : Form
    {
        public frmFallingObjects()
        {
            InitializeComponent();
        }

        private void txtNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGetNumber_Click(object sender, EventArgs e)
        {
            double usersAnswer;

            usersAnswer = double.Parse(txtNumberBox.Text);

            lblDisplayedAnswer.Text = Convert.ToString(100 - 0.5 * 9.81 * (Math.Pow(usersAnswer, 2)));



        }
    }
}
