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
    public partial class Login : Form
    {
        string t = "";
        Controller controllerObj; 
        public Login( string tybe)
        {
            InitializeComponent();
            controllerObj = new Controller();  
            t = tybe;   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "User Name"  && textBox2.Text== "Pasword")
            {
                MessageBox.Show("You should enter the username and password ");
                return;
            }
            if (textBox1.Text == "User Name" )
            {
                MessageBox.Show("You should enter the username ");
                return;
            }
            if (textBox2.Text == "Pasword")
            {
                MessageBox.Show("You should enter the password ");
                return;
            }

            string user = textBox1.Text.ToString();
            int password =0;
            if (t == "Doctor")
            {
                password = controllerObj.gitDocPassword(user); // get the password to compare
            }
            else if (t== "Patient")
            {
                password = controllerObj.gitPatientPassword(user);
            }
            else if(t== "Recep")
            {
               
                password = controllerObj.gitRepPassword(user);
            }
            else
            {
                password = controllerObj.gitAdminPassword(user);
            }
            if (password == 0)
            {
                MessageBox.Show("The user you entered doesn't exist");
                return;
            }
            if (password.ToString() != textBox2.Text.ToString())
            {
                MessageBox.Show("Wrong passowrd");
                return ;
            }

            // if you reched here that is mean that both the username and password are right
            // then you will call the new form and path the userName to it
            if (t == "Doctor")
            {
                this.Close();   
                Doctor doctor = new Doctor (user);
                doctor.Show();
            }
            else if (t == "Patient")
            {
                this.Close();
                Patient patient = new Patient(user);
                patient.Show();
            }
            else if (t == "Recep")
            {
                this.Hide();
                Receptionist R = new Receptionist(user);
                R.Show();
            }
            else
            {
                this.Hide();
                Admin admin = new Admin();  
                admin.Show();   
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox2.PasswordChar = '\0';
            else
                textBox2.PasswordChar = '*';
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (t== "Patient")
            {
                button2.Visible = true;
                label2.Visible = true;
            }
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AddPation A = new AddPation("new");
            A.Show();
        }
    }
}
