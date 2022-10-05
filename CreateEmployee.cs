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
    public partial class CreateEmployee : Form
    {
        class employee
        {
            // attributes
            protected string fname;
            protected string lname;

            public employee(string fn, string ln) // this is your employee constructor
            {
                this.fname = fn;
                this.lname = ln;
                MessageBox.Show("New Employee"); // this shows that you got here 
            }
            public void display()
            {
                MessageBox.Show(" Employee Full Name: " + this.fname + ' ' + this.lname); // inside display
            }

            public string getfn()
            { return this.fname; } // where you put your checks in 

            public void setfn(string fn)
            {
                this.fname = fn; // sets values
            }
        }
        class FT:employee // this creates inheritance 
        {
            //attributes
            private double salary;

            public FT(string fn, string ln, double sal) : base(fn, ln)
            {
                this.salary = sal;
            }
            public void displayFT()
            {
                base.display();
                MessageBox.Show(" Full Time Employee Salary: " + this.salary.ToString()); // inside FT display 
            }
        }
        class PT:employee // this creates inheritance
        {
            //attributes
            private int hoursWorked;

            public PT(string fn, string ln, int hw) : base(fn, ln)
            {

                this.hoursWorked = hw;
            }
            public void displayPT()
            {
                base.display();
                MessageBox.Show("Part-Time Employee Hourly Pay: " + this.hoursWorked.ToString()); // displays hours worked
            }
        }
        public CreateEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // create employee button
        {
            employee e1 = new employee(textBox1.Text, textBox2.Text); // this creates an employee
            e1.display();
        }

        private void button2_Click(object sender, EventArgs e) // creates full time employee button 
        {
            textBox3.Visible = true;
            MessageBox.Show("Full-Time Employee"); // shows the message "Full time employee"
            double sal = double.Parse(textBox3.Text);
            FT f1 = new FT(textBox1.Text, textBox2.Text, sal);
            f1.displayFT();
        }

        private void button3_Click(object sender, EventArgs e) // creates part time employee
        {
            MessageBox.Show("Part-Time Employee");
            int hw = int.Parse(textBox3.Text);
            PT P1 = new PT(textBox1.Text, textBox2.Text, hw);
            P1.displayPT();
        }

        private void CreateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) // retun to main page button 
        {
            Form1 frm = new Form1(); // this creates the form 
            this.Hide(); // hides the form in main page
            frm.Show(); // shows the new page 
        }

        private void button5_Click(object sender, EventArgs e) // goes to benefits page 
        {
            EmployeeBenefitsPage frm = new EmployeeBenefitsPage(); // this creates the form 
            this.Hide(); // hides the form in main page
            frm.Show(); // shows the new page 
        }
    }
}
