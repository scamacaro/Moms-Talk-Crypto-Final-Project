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
    public partial class EmployeeBenefitsPage : Form
    {
        int[] nums = new int[100];
        Random rand = new Random();
        int die;
        public EmployeeBenefitsPage()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CalculateBonusButton_Click(object sender, EventArgs e) // calculates bonus
        {
            decimal calcula_percentage = (Convert.ToDecimal(comboBox1.Text) / 100) * Convert.ToDecimal(textBox1.Text);
            textBox2.Text = (decimal.Parse(textBox1.Text) + calcula_percentage).ToString();
        }

        private void button3_Click(object sender, EventArgs e) // calculates available pto depending on dob
        {
            DateTime startdate = dobdateTimePicker1.Value;
            DateTime Enddate = dateTimePicker2.Value;
            textBox3.Text = CalcAge(startdate, Enddate).ToString();
        }
        public long CalcAge(System.DateTime StartDate, System.DateTime EndDate)
        {
            long age = 0;
            System.TimeSpan ts = new TimeSpan(EndDate.Ticks - StartDate.Ticks);
            age = (long)(ts.Days / 365);
         
            return age;
        }

        private void button4_Click(object sender, EventArgs e) // weekly worked hours button 
        {
            int result;
            string str = HourWeeklyTextBox.Text;
            if (int.TryParse(str, out result))
            {
                if (result <= 40)
                {
                    MessageBox.Show("You Have 3 Hours Of Earned PTO");
                }
                else if (result <= 80)
                {
                    MessageBox.Show("You Have 6 Hours Of Earned PTO");
                }
            }
            else
            {
                MessageBox.Show("Not a Valid Integer");
            }
            try//if its not an integer it will catch the error
            {
                result = int.Parse(str);
            }
            catch
            {
                MessageBox.Show("Enter Valid Hours");
                MessageBox.Show("Please Try Again!");
               
                }
            }

        private void button5_Click(object sender, EventArgs e) // return to main page button 
        {
            Form1 frm = new Form1(); // this creates the form 
            this.Hide(); // hides the form in main page
            frm.Show(); // shows the new page 
        }
    }
}
