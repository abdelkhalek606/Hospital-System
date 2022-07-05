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
    public partial class adminaddpatientsandrelatives : Form
    {
        Controller controllerObj;
        public adminaddpatientsandrelatives()
        {
            
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.Selectpatid();
            relsaptcombobox.DataSource = dt;
            relsaptcombobox.DisplayMember = "SSN";

            patssn.Maximum = Int32.MaxValue;
            patssn.Minimum = 0;

            patientphone.Maximum = Int32.MaxValue;
            patientphone.Minimum = 0;

            relativephone.Maximum = Int32.MaxValue;
            relativephone.Minimum = 0;

            relativessn.Maximum = Int32.MaxValue;
            relativessn.Minimum = 0;
        }

        private void patientbutton_Click(object sender, EventArgs e)
        {
            if (patpass.Text == "" || patusername.Text == "" || patssn.Value == 0 || patfname.Text == ""
               || patlname.Text == "" || patminit.Text == "" || patientphone.Value == 0 || patientgender.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            //

            int number;

            bool success = int.TryParse(patpass.Text.ToString(), out number);
            if (!success)
            {
                MessageBox.Show("please enter correct password ex:1,2,3");
                return;
            }

            else
            {
                int count = Convert.ToInt32(Math.Round(patssn.Value, 0));
                int phone = Convert.ToInt32(Math.Round(patientphone.Value, 0));

                int r = controllerObj.InsertpatientA(patientgender.Text.ToString(), patfname.Text.ToString(), patminit.Text.ToString(),
                    patlname.Text.ToString(), patusername.Text.ToString(),Int32.Parse(patpass.Text), count, phone , patbdate.Value);
                MessageBox.Show("inserted successfully");
            }
        }

        private void relativebutton_Click(object sender, EventArgs e)
        {
            if (relativessn.Value == 0 || relativename.Text == "" || relativesex.Text == "" ||
                  relationship.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int ssn = Int32.Parse(relsaptcombobox.Text);
                int count = Convert.ToInt32(Math.Round(relativessn.Value, 0));
                int phone = Convert.ToInt32(Math.Round(relativephone.Value, 0));

                int r = controllerObj.Insertrelative(relativename.Text.ToString(), ssn, relationship.Text.ToString(),
                    count, dateTimePicker3.Value, relativesex.Text.ToString(), phone);
                MessageBox.Show("inserted successfully");
            }
        }

        private void adminaddpatientsandrelatives_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
            groupBox2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            adminadd a = new adminadd();
            a.Show();
        }

        private void patpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
