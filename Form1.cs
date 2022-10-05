/*
 Sanyerlis Camacaro 10/05/2022 - CSC202 - CEO FINAL SUBMISSION - Moms Talk Crypto Company - Sancamac@uat.edu
Log: As of October 3rd,2022 I believe this project will take me to complete in less than 8 hours splitted in 2-3 days.
10/04/2022 Started rewatching the class to follow along with the examples, adding functions I was missing to my project.
I started at 11:30pm and finished at 10/05/2022 at 2:30am. 

To Complete this Final Project I've expected to complete the project within the most 3 days in total of 8 hours. In total I took 3 hours in one day. I worked in 
advanced in this project to enjoy my birthday weekend. 
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

namespace Moms_Talk_Crypto_CEO_Final_Submission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Button for Welcome To Moms Talk Crypto Page
        {
            MessageBox.Show("Welcome To Moms Talk Employee Page!"); // Message that appears in Welcome Banner when you click 
        }

        private void pictureBox1_Click(object sender, EventArgs e) // Moms Talk Crypto Logo 
        {

        }

        private void button2_Click(object sender, EventArgs e) // button that takes you to Create Username Page
        {
            CreateUsername frm = new CreateUsername(); // this creates the form 
            this.Hide(); // hides the form in main page
            frm.Show(); // shows the new page 
        }

        private void button3_Click(object sender, EventArgs e) // this button takes you to employee page
        {
            CreateEmployee frm = new CreateEmployee(); // this creates the form 
            this.Hide(); // hides the form in main page
            frm.Show(); // shows the new page 
        }

        private void button4_Click(object sender, EventArgs e) // this button takes you to employee benefits page 
        {
            EmployeeBenefitsPage frm = new EmployeeBenefitsPage(); // this creates the form 
            this.Hide(); // hides the form in main page
            frm.Show(); // shows the new page 
        }

        private void button5_Click(object sender, EventArgs e) // this button takes you to Play Jack Pot Page
        {
            PlayJackPot frm = new PlayJackPot(); // this creates the form 
            this.Hide(); // hides the form in main page
            frm.Show(); // shows the new page
        }

        private void button6_Click(object sender, EventArgs e) // this button takes you to hourly earnings
        {
            Hourly_Earnings frm = new Hourly_Earnings(); // this creates the form 
            this.Hide(); // hides the form in main page
            frm.Show(); // shows the new page
        }
    }
}
