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
    public partial class Profile : Form
    {
        string Name = "";
        int password = 0;
        string usernaem = "";
        int SSN = 0;
        int PhoneNumber= 0;
        int DNO = 0;
        string Gender = "";
        string T;
        Controller controllerObj;

        public Profile(string Type , string user)
        {
            InitializeComponent();
            controllerObj = new Controller();
            T = Type;
            if (Type == "doc")
            {
                password = controllerObj.gitDocPassword(user);
                Name = controllerObj.gitDocName(user);
                usernaem = user;
                DNO =  controllerObj.gitDocDNO(user);
                label1.Text = Name;
                label3.Text = usernaem;
                label5.Text= password.ToString();
                label7.Visible = true;
                label8.Visible = true;
                label8.Text = DNO.ToString();   
            }
            else if (Type == "Rec")
            {
                password = controllerObj.gitRepPassword(user);
                usernaem=user;
                Name = controllerObj.gitRecpName(user);
                label1.Text = Name;
                label3.Text = usernaem;
                label5.Text = password.ToString();

            }
            else if (Type == "pat")
            {
                password=controllerObj.gitPatientPassword(user);
                usernaem = user;
                Name = controllerObj.gitPatientName(user);
                SSN = controllerObj.gitPatientSSN(user);
                PhoneNumber =controllerObj.gitPatientPhone(user);
                Gender = controllerObj.gitPatientGender(user);
                label1.Text = Name;
                label3.Text = usernaem;
                label5.Text = password.ToString();
                button4.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label10.Text = SSN.ToString();
                label14.Visible = true;
                label13.Visible = true;
                button6.Visible = true;
                label13.Text = PhoneNumber.ToString();
                label15.Visible = true;
                label16.Visible = true;
                button7.Visible = true;
                label16.Text = Gender;

            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            //
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1 == null)
            {
                MessageBox.Show("please inter the new value");
                return;
            }
            int p = Int32.Parse(textBox1.Text);
            if(T== "pat")
            {
                int q = controllerObj.updatepatusernamepass(SSN, usernaem, p);
            }
            else if (T == "doc")
            {
                int q = controllerObj.updatedocusernamepass2(usernaem, p);
            }
            else
            {
                int q = controllerObj.updaterecepusernamepass2(usernaem,p);
            }
            label5.Text = textBox1.Text.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2 == null)
            {
                MessageBox.Show("please inter the new value");
                return;
            }

            int q = controllerObj.updatepatientSSN(usernaem, Int32.Parse(textBox2.Text.ToString()));
            label10.Text =  textBox2.Text.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label11.Visible = true;
            textBox2.Visible = true;
            button2.Visible = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            //
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label12.Visible = true;
            textBox3.Visible= true;
            button5.Visible= true;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label17.Visible = true;
            button8.Visible = true;
            comboBox1.Visible = true;

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1 == null)
            {
                MessageBox.Show("please inter the new value");
                return;
            }
            int q = controllerObj.updatepatientsex(SSN,comboBox1.Text.ToString());
            label16.Text = comboBox1.Text.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox3 == null)
            {
                MessageBox.Show("please inter the new value");
                return;
            }

            if (T == "pat")
            {
                int q = controllerObj.updatepatientphone(SSN, Int32.Parse(textBox3.Text));
                label13.Text = textBox3.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(T== "doc")
            {
                this.Close();
                Doctor doctor = new Doctor(usernaem);
                doctor.Show();
            }else if (T== "pat")
            {
                this.Close();
                Patient patient = new Patient(usernaem);
                patient.Show();

            }else if (T== "Rec")
            {
                this.Close();
                Receptionist receptionist = new Receptionist(usernaem); 
                    receptionist.Show();
            }
            else
            {
                this.Close();
            }
        }
    }
}
