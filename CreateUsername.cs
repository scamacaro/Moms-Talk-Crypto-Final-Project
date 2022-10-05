using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Moms_Talk_Crypto_CEO_Final_Submission
{
    public partial class CreateUsername : Form
    {
        string str1, str2;
        int[] nums = new int[100];
        Random rand = new Random();
        public CreateUsername()
        {
            InitializeComponent();
        }

        private void PassCodebutton_Click(object sender, EventArgs e) // generate username button
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\sanye\source\repos\Moms Talk Crypto Company Benefits Arrays, Strings, and Sound\Chime.wav"); // plays sound 
            simpleSound.Play();
            str1 = Nametextbox.Text;
            if (str1.Length > 5) // it says if the letters are greater than 5
            {
                str2 = str1.Substring(0, 5);
                str2 = str2.Trim(); // trim the username 
                Nametextbox.Text = str2;
                {
                    Nametextbox.Text = Nametextbox.Text.ToUpper(); //Uppercases the new username 
                }
            }
            }

        private void button3_Click(object sender, EventArgs e) // when you click this button accept it goes to CreateEmployee form
        {
            CreateEmployee frm = new CreateEmployee(); // this creates the form 
            this.Hide(); // hides the form in main page
            frm.Show(); // shows the new page 
        }

        private void Generatebutton_Click(object sender, EventArgs e)
        {
            String strnum1 = "";
            for (int i = 0; i < 100; i++)
            {
                nums[i] = rand.Next(0, 1000);
                strnum1 = strnum1 + nums[i].ToString() + " ";
            }
            textBox1.Text = strnum1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Array.Sort(nums);
            String strnum1 = "";
            for (int i = 0; i < 100; i++)
            {
                nums[i] = rand.Next(0, 1000);
                strnum1 = strnum1 + nums[i].ToString() + " ";
            }
            textBox1.Text = strnum1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(); // this creates the form 
            this.Hide(); // hides the form in main page
            frm.Show(); // shows the new page 
        }

        private void button2_Click(object sender, EventArgs e) // button that verifies if you input the same letters
        {
            str1 = Nametextbox.Text;
            str2 = VerifyButton.Text;
            if (str1 == str2)
                MessageBox.Show("Accepted, Click Accept and Generate Username To Proceed"); // if its good it shows this message 
        }
    }
}
