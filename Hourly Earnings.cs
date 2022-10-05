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
    public partial class Hourly_Earnings : Form
    {
        int die;
        Random rand = new Random();
        public Hourly_Earnings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // displays what the company makes hourly 
        {
            Random random = new Random();
            die = random.Next(100, 10000);
            MessageBox.Show("Company Hourly Earnings =" + die);
            die++; //SC equivalent to die = die +1;
        }

        private void button3_Click(object sender, EventArgs e) // retuns to main page 
        {
            Form1 frm = new Form1(); // this creates the form 
            this.Hide(); // hides the form in main page
            frm.Show(); // shows the new page
        }
    }
    }

