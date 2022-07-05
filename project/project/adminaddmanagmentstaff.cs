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
    public partial class adminaddmanagmentstaff : Form
    {
        Controller controllerObj;
        public adminaddmanagmentstaff()
        {
            InitializeComponent();
            controllerObj = new Controller();
            recepid.Maximum = Int32.MaxValue;
            recepid.Minimum = 0;
            depdno.Maximum = Int32.MaxValue;
            depdno.Minimum = 0;
            adminid.Maximum = Int32.MaxValue;
            adminid.Minimum = 0;
        }

        private void receptionstbutton_Click(object sender, EventArgs e)
        {
            if (recepid.Value == 0 || recepname.Text == "" || recepusername.Text == "" || receppass.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            int number;

            bool success = int.TryParse(receppass.Text.ToString(), out number);
            if (!success)
            {
                MessageBox.Show("please enter correct password ");
                return;
            }
            else
            {
                int count = Convert.ToInt32(Math.Round(recepid.Value, 0));
                int r = controllerObj.Insertrecep(recepname.Text.ToString(), count, recepusername.Text.ToString(), Int32.Parse(receppass.Text));
                MessageBox.Show("inserted successfully");
            }
        }

        private void adminbutton_Click(object sender, EventArgs e)
        {
            if (adminid.Value == 0 || adminname.Text == "" || adminuser.Text == "" || adminpass.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            //adminpass

            int number;

            bool success = int.TryParse(adminpass.Text.ToString(), out number);
            if (!success)
            {
                MessageBox.Show("please enter correct password ");
                return;
            }
            else
            {
                int count = Convert.ToInt32(Math.Round(adminid.Value, 0));
                int r = controllerObj.Insertadmin(adminname.Text.ToString(), count, adminuser.Text.ToString(), Int32.Parse(adminpass.Text));
                MessageBox.Show("inserted successfully");
            }
        }

        private void depbutton_Click(object sender, EventArgs e)
        {
            if (depdno.Value == 0 || depname.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int count = Convert.ToInt32(Math.Round(depdno.Value, 0));
                int r = controllerObj.Insertdep(depname.Text.ToString(), count);
                MessageBox.Show("inserted successfully");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void depname_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void adminaddmanagmentstaff_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
            groupBox2.BackColor = Color.FromArgb(100, 0, 0, 0);
            groupBox3.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            adminadd A = new adminadd(); 
            A.Show();
        }

        private void receppass_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
