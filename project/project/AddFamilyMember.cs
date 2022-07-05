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
    public partial class AddFamilyMember : Form
    {
        string US = "";
        string TS = "";
        Controller controllerObj;
        int SSN = 0;
        string user = "";
        public AddFamilyMember(string u , string U, string T)
        {
            InitializeComponent();
            controllerObj = new Controller();
            US = U;
            TS = T;
            SSN = controllerObj.gitPatientSSN(u);
            user = u;


        }

        private void AddFamilyMember_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // SSN
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1==null || textBox2== null || textBox3 == null || textBox4 == null || comboBox1 == null || dateTimePicker1== null)
            {
                MessageBox.Show("Please fill all the data");
                return;
            }

            int number;

            bool success = int.TryParse(textBox4.Text.ToString(), out number);
            if (!success)
            {
                MessageBox.Show("please enter Correct SSN Ex 1,2,3");
                return ;
            }




                int q = controllerObj.AddRelative(textBox1.Text.ToString(), comboBox1.Text.ToString(), textBox2.Text.ToString(), Convert.ToInt32(textBox3.Text.ToString()), Convert.ToInt32(textBox4.Text.ToString()), SSN, dateTimePicker1.Value.ToString());
            
            this.Close();

            if (TS == "Recep")
            {
                this.Close();
                FamilyMember F = new FamilyMember(US, TS);
                F.Show();
            }

            if (TS == "pat")
            {
                this.Close();
                Patient p = new Patient(user);
                p.Show();

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Name
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Gender
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //RElationship
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //PhoneNum
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // BIRTH
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(TS== "Recep")
            {
                this.Close();   
                FamilyMember F = new FamilyMember(US,TS);
                F.Show();   
            }

            if(TS== "pat")
            {
                this.Close();
                Patient p = new Patient(user);
                p.Show();   

            }
        }
    }
}
