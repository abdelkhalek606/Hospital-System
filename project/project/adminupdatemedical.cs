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
    public partial class adminupdatemedical : Form
    {
        Controller controllerObj;

        public adminupdatemedical()
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable roomiddt = controllerObj.Selectroomid();
            comboboxroom.DataSource = roomiddt;
            comboboxroom.DisplayMember = "id";

            DataTable cliniciddt = controllerObj.Selectclinicid();
            comboBoxclinc.DataSource = cliniciddt;
            comboBoxclinc.DisplayMember = "id";

            DataTable ambiddt = controllerObj.Selectambid();
            comboBoxamb.DataSource = ambiddt;
            comboBoxamb.DisplayMember = "id";

            DataTable dociddt = controllerObj.Selectdocid();
            comboBoxdoc.DataSource = dociddt;
            comboBoxdoc.DisplayMember = "id";

            DataTable depnodt = controllerObj.SelectDepnum();
            comboboxdno.DataSource = depnodt;
            comboboxdno.DisplayMember = "Dnumber";

            DataTable nurseiddt = controllerObj.Selectnursesid();
            comboboxnurse.DataSource = nurseiddt;
            comboboxnurse.DisplayMember = "id";
        }

        private void adminupdatemedical_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
            groupBox2.BackColor = Color.FromArgb(100, 0, 0, 0);
            groupBox3.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void doctordnobutton_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(comboBoxdoc.Text);
            int number2 = Int32.Parse(comboboxdno.Text);
            int r = controllerObj.updatedocdep(number1, number2);
            MessageBox.Show("updated successfully");
        }

        private void doctornamebutton_Click(object sender, EventArgs e)
        {

            if (doctorname.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int number1 = Int32.Parse(comboBoxdoc.Text);
                int r = controllerObj.updatedocname(number1, doctorname.Text.ToString());
                MessageBox.Show("updated successfully");
            }
        }

        private void doctorclincbutton_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(comboBoxdoc.Text);
            int number2 = Int32.Parse(comboBoxclinc.Text);
            int r = controllerObj.updatedocclinc(number1, number2);
            MessageBox.Show("updated successfully");
        }

        private void nurseupdatebutton_Click(object sender, EventArgs e)
        {
            if (nursename.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int number1 = Int32.Parse(comboboxnurse.Text);
                int r = controllerObj.updatenursename(number1, nursename.Text.ToString());
                MessageBox.Show("updated successfully");
            }
        }

        private void changenurseroombutton_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(comboboxnurse.Text);
            int number2 = Int32.Parse(comboboxroom.Text);
            int r = controllerObj.updatenurseroom(number1, number2);
            MessageBox.Show("updated successfully");
        }

        private void ambulanceupdate_Click(object sender, EventArgs e)
        {
            if (ambulancedriver.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int number1 = Int32.Parse(comboBoxamb.Text);
                int r = controllerObj.updateambulancedriver(number1, ambulancedriver.Text.ToString());
                MessageBox.Show("updated successfully");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            adminupdatedata A = new adminupdatedata();
            A.Show();
        }
    }
}
