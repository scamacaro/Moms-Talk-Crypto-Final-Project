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
    public partial class PlayJackPot : Form
    {
        int die;
        Random rand = new Random();
        public PlayJackPot()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // plays randon numbers that gives you extra days of pto
        {
            Random random = new Random();
            die = random.Next(1, 10);
            MessageBox.Show("Extra Vacation Days =" + die);
            die++; //SC equivalent to die = die +1;
            MessageBox.Show("Bonus JACKPOT =" + die);
            die = die + 8;
        }

        private void button3_Click(object sender, EventArgs e) // returns to main page button 
        {
            Form1 frm = new Form1(); // this creates the form 
            this.Hide(); // hides the form in main page
            frm.Show(); // shows the new page
        }
    }
}
