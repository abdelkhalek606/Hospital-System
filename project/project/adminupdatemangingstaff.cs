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
    public partial class adminupdatemangingstaff : Form
    {
        Controller controllerObj;
        public adminupdatemangingstaff()
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable dociddt = controllerObj.Selectdocid();
            comboBoxdepsuper.DataSource = dociddt;
            comboBoxdepsuper.DisplayMember = "id";

            DataTable depnodt = controllerObj.SelectDepnum();
            comboBoxdepdno.DataSource = depnodt;
            comboBoxdepdno.DisplayMember = "Dnumber";

            DataTable adminiddt = controllerObj.Selectadminid();
            comboBoxadmin.DataSource = adminiddt;
            comboBoxadmin.DisplayMember = "id";

            DataTable recepiddt = controllerObj.Selectrecepid();
            comboBoxrecep.DataSource = recepiddt;
            comboBoxrecep.DisplayMember = "id";
        }

        private void adminupdatemangingstaff_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
            groupBox2.BackColor = Color.FromArgb(100, 0, 0, 0);
            groupBox3.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void receptionstbutton_Click(object sender, EventArgs e)
        {
            if (textBoxrecep.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int number1 = Int32.Parse(comboBoxrecep.Text);
                int r = controllerObj.updaterecepname(number1, textBoxrecep.Text.ToString());
                MessageBox.Show("updated successfully");
            }
        }

        private void adminbutton_Click(object sender, EventArgs e)
        {
            if (textBoxadmin.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int number1 = Int32.Parse(comboBoxadmin.Text);
                int r = controllerObj.updateadminname(number1, textBoxadmin.Text.ToString());
                MessageBox.Show("updated successfully");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(comboBoxdepdno.Text);
            int number2 = Int32.Parse(comboBoxdepsuper.Text);
            int r = controllerObj.updatedepsupervisor(number2, number1);
            MessageBox.Show("updated successfully");
        }

        private void textBoxrecep_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxdepdno_SelectedIndexChanged(object sender, EventArgs e)
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
