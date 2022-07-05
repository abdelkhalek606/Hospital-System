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
    public partial class adminpasswordmanagement : Form
    {
        Controller controllerObj;
        public adminpasswordmanagement()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dociddt = controllerObj.Selectdocid();
            comboBoxdoc.DataSource = dociddt;
            comboBoxdoc.DisplayMember = "id";

            DataTable patiddt = controllerObj.Selectpatid();
            comboBoxpat.DataSource = patiddt;
            comboBoxpat.DisplayMember = "SSN";

            DataTable adminiddt = controllerObj.Selectadminid();
            comboBoxadmin.DataSource = adminiddt;
            comboBoxadmin.DisplayMember = "id";

            DataTable recepiddt = controllerObj.Selectrecepid();
            comboBoxrecep.DataSource = recepiddt;
            comboBoxrecep.DisplayMember = "id";
        }

        private void adminpasswordmanagement_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
            groupBox2.BackColor = Color.FromArgb(100, 0, 0, 0);
            groupBox3.BackColor = Color.FromArgb(100, 0, 0, 0);
            groupBox4.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void patbutton_Click(object sender, EventArgs e)
        {
            if (patuser.Text == "" || patpass.Text == "")
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
                int number1 = Int32.Parse(comboBoxpat.Text);
                int r = controllerObj.updatepatusernamepass(number1, patuser.Text.ToString(), Int32.Parse(patpass.Text));
                MessageBox.Show("updated successfully");
            }
        }

        private void docbutton_Click(object sender, EventArgs e)
        {
            if (docuser.Text == "" || docpass.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            //
            int number;

            bool success = int.TryParse(docpass.Text.ToString(), out number);
            if (!success)
            {
                MessageBox.Show("please enter correct password ex:1,2,3");
                return;
            }
            else
            {
                int number1 = Int32.Parse(comboBoxdoc.Text.ToString());
                int r = controllerObj.updatedocusernamepass(number1, docuser.Text.ToString(), Int32.Parse(docpass.Text));
                MessageBox.Show("updated successfully");
            }
        }

        private void receptionstbutton_Click(object sender, EventArgs e)
        {
            if (recepuser.Text == "" || receppass.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            //receppass
            int number;

            bool success = int.TryParse(receppass.Text.ToString(), out number);
            if (!success)
            {
                MessageBox.Show("please enter correct password ex:1,2,3");
                return;
            }
            else
            {
                int number1 = Int32.Parse(comboBoxrecep.Text);
                int r = controllerObj.updaterecepusernamepass(number1, recepuser.Text.ToString(), Int32.Parse(receppass.Text));
                MessageBox.Show("updated successfully");
            }
        }

        private void adminbutton_Click(object sender, EventArgs e)
        {
            if (adminuser.Text == "" || adminpass.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            // 
            int number;

            bool success = int.TryParse(adminpass.Text.ToString(), out number);
            if (!success)
            {
                MessageBox.Show("please enter correct password ex:1,2,3");
                return;
            }
            else
            {
                int number1 = Int32.Parse(comboBoxadmin.Text);
                int r = controllerObj.updateadminusernamepass(number1, adminuser.Text.ToString(),Int32.Parse(adminpass.Text));
                MessageBox.Show("updated successfully");
            }
        }

        private void adminpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void patpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void patuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void docpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxpat == null)
            {
                MessageBox.Show("Select Patient ID");
                return;
            }

            DataTable dt = new DataTable();
            dt = controllerObj.getUserNameAndPassOfPat(Convert.ToInt32(comboBoxpat.Text.ToString()));

            string[,] x = new string[dt.Rows.Count, dt.Columns.Count];
            int i = 0;
            int c = 0;
            foreach (DataRow row in dt.Rows)
            {
                for (int k = 0; k < dt.Columns.Count; k++)
                {
                    x[c, i] = row.ItemArray.GetValue(k).ToString();
                    i++;
                }
                i = 0;
                c++;
            }

            patuser.Text = x[0, 0];
            patpass.Text = x[0, 1]; 


        }

        private void comboBoxpat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void docuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxdoc == null)
            {
                MessageBox.Show("Select Doctor ID");
                return;
            }
            DataTable dt = new DataTable();
            //
            dt = controllerObj.getUserNameAndPassOfDoc(Convert.ToInt32(comboBoxdoc.Text.ToString()));
            string[,] x = new string[dt.Rows.Count, dt.Columns.Count];
            int i = 0;
            int c = 0;
            foreach (DataRow row in dt.Rows)
            {
                for (int k = 0; k < dt.Columns.Count; k++)
                {
                    x[c, i] = row.ItemArray.GetValue(k).ToString();
                    i++;
                }
                i = 0;
                c++;
            }
            docuser.Text= x[0, 0];
            docpass.Text= x[0, 1];  
        }

        private void comboBoxdoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // getUserNameAndPassOfRecep

            if (comboBoxrecep == null)
            {
                MessageBox.Show("Select Receptioist ID");
                return;
            }
            DataTable dt = new DataTable();
            //
            dt = controllerObj.getUserNameAndPassOfRecep(Convert.ToInt32(comboBoxrecep.Text.ToString()));
            string[,] x = new string[dt.Rows.Count, dt.Columns.Count];
            int i = 0;
            int c = 0;
            foreach (DataRow row in dt.Rows)
            {
                for (int k = 0; k < dt.Columns.Count; k++)
                {
                    x[c, i] = row.ItemArray.GetValue(k).ToString();
                    i++;
                }
                i = 0;
                c++;
            }
            recepuser.Text = x[0, 0];
            receppass.Text = x[0, 1];

        }

        private void comboBoxrecep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void recepuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void receppass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBoxadmin == null)
            {
                MessageBox.Show("Select Receptioist ID");
                return;
            }
            DataTable dt = new DataTable();
            //
            dt = controllerObj.getUserNameAndPassOfAdmin(Convert.ToInt32(comboBoxadmin.Text.ToString()));
            string[,] x = new string[dt.Rows.Count, dt.Columns.Count];
            int i = 0;
            int c = 0;
            foreach (DataRow row in dt.Rows)
            {
                for (int k = 0; k < dt.Columns.Count; k++)
                {
                    x[c, i] = row.ItemArray.GetValue(k).ToString();
                    i++;
                }
                i = 0;
                c++;
            }
            adminuser.Text = x[0, 0];
            adminpass.Text = x[0, 1];
        }

        private void comboBoxadmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adminuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
           
            adminupdatedata A = new adminupdatedata();
            A.Show();
        }
    }
}
