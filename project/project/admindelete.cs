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
    public partial class admindelete : Form
    {
        Controller controllerObj;
        public admindelete()
        {
            
            InitializeComponent();
            controllerObj = new Controller();

            DataTable dociddt = controllerObj.Selectdocid();
            comboBoxdoc.DataSource = dociddt;
            comboBoxdoc.DisplayMember = "id";

            DataTable depnodt = controllerObj.SelectDepnum();
            comboBoxdno.DataSource = depnodt;
            comboBoxdno.DisplayMember = "Dnumber";

            DataTable patiddt = controllerObj.Selectpatid();
            comboBoxpat.DataSource = patiddt;
            comboBoxpat.DisplayMember = "SSN";

            DataTable nurseiddt = controllerObj.Selectnursesid();
            comboBoxnurse.DataSource = nurseiddt;
            comboBoxnurse.DisplayMember = "id";

            DataTable adminiddt = controllerObj.Selectadminid();
            comboBoxadmin.DataSource = adminiddt;
            comboBoxadmin.DisplayMember = "id";

            DataTable recepiddt = controllerObj.Selectrecepid();
            comboBoxrecep.DataSource = recepiddt;
            comboBoxrecep.DisplayMember = "id";

            DataTable roomiddt = controllerObj.Selectroomid();
            comboBoxroom.DataSource = roomiddt;
            comboBoxroom.DisplayMember = "id";

            DataTable cliniciddt = controllerObj.Selectclinicid();
            comboBoxclinic.DataSource = cliniciddt;
            comboBoxclinic.DisplayMember = "id";

            DataTable ambiddt = controllerObj.Selectambid();
            comboBoxamb.DataSource = ambiddt;
            comboBoxamb.DisplayMember = "id";

            DataTable relaiddt = controllerObj.Selectrelativeid();
            comboBoxrela.DataSource = relaiddt;
            comboBoxrela.DisplayMember = "relative_ssn";
        }

        private void admindelete_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void nursebutton_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(comboBoxnurse.Text);
            int r = controllerObj.deletenurse(number1);
            MessageBox.Show("deleted successfully");
        }

        private void docbutton_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(comboBoxdoc.Text);
            int r = controllerObj.deletedoctor(number1);
            MessageBox.Show("deleted successfully");
        }

        private void receptionstbutton_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(comboBoxrecep.Text);

            int r = controllerObj.deleteareceptionist(number1);

            MessageBox.Show("deleted successfully");
        }

        private void adminbutton_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(comboBoxadmin.Text);
            int r = controllerObj.deleteadmin(number1);
            MessageBox.Show("deleted successfully");
        }

        private void ambulancebutton_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(comboBoxamb.Text);
            int r = controllerObj.deleteambulance(number1);
            MessageBox.Show("deleted successfully");
        }

        private void depbutton_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(comboBoxdno.Text);
            int r = controllerObj.deletedep(number1);
            MessageBox.Show("deleted successfully");
        }

        private void patbutton_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(comboBoxpat.Text);
            int r = controllerObj.deletepatient(number1);
            MessageBox.Show("deleted successfully");
        }

        private void roombutton_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(comboBoxroom.Text);
            int r = controllerObj.deleteroom(number1);
            MessageBox.Show("deleted successfully");
        }

        private void clincbutton_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(comboBoxclinic.Text);
            int r = controllerObj.deleteclinic(number1);
            MessageBox.Show("deleted successfully");
        }

        private void relabutton_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(comboBoxrela.Text);
            int r = controllerObj.deleterelative(number1);
            MessageBox.Show("deleted successfully");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin admin = new Admin();
            admin.Show();
        }
    }
}
