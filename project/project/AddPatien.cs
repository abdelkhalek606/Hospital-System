using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddPation : Form
    {
        string user = "";
        Controller controllerObj;
        public AddPation(string U)
        {
            InitializeComponent();
            user = U;
        }

        private void AddPation_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

  

       

        private void midldenametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void fnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
        }

        private void fnametxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void midldenametxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lastnametext_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            if (user == "new")
            {
                Login login = new Login("Patient");
                login.Show();   
            }
            else
            {
                PatientOperations P = new PatientOperations(user);
                P.Show();
            }
          
        }

        private void submit_Click_1(object sender, EventArgs e)
        {

            usernameerrror.Visible = false;
            if (passwordtext1.Text != passwordtxt2.Text)
            {
                passworderror.Visible = true;
                return;
            }
            passworderror.Visible = false;


            if (fnametxt.Text == "")//validation part
            {
                MessageBox.Show("Please, insert your frist name");
                return;

            }
            if (midldenametxt.Text == "")//validation part
            {
                MessageBox.Show("Please, insert your middle name name");
                return;

            }
            if (lastnametext.Text == "")//validation part
            {
                MessageBox.Show("Please, insert your last name name");
                return;
            }

            if (passwordtext1.Text == "")//validation part
            {
                MessageBox.Show("Please, insert your password");
                return;
            }

            if (username.Text == "")//validation part
            {
                MessageBox.Show("Please, insert your username");
                return;
            }
            int number;

            bool success = int.TryParse(passwordtext1.Text, out number);
            if (!success)
            {
                MessageBox.Show("Please, insert Correct password EX 1,2,3");
                return ;
            }
           

            String st = "";

            if (femalradiobutton.Checked == true)
            { st = "Female"; }
            else if (malerdiobutton.Checked == true)
                st = "Male";
            else
                return;
            controllerObj = new Controller();
            int r = 0;
        


            r = controllerObj.Insertpatient(fnametxt.Text, midldenametxt.Text, lastnametext.Text, Convert.ToInt32(ssn.Text), dateofbirth.Value, st, Convert.ToInt32(phonenumber.Text.ToString()), username.Text.ToString(), phonenumber.Text.ToString());

            if (r == 0)
            {
                
                usernameerrror.Visible = true;
            }
            else
            {
                MessageBox.Show("department location inserted successfully");
            }

            if (user == "new")
            {
                this.Close();
                Login L = new Login("Patient");
                L.Show();
            }
        }

        private void ssn_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


