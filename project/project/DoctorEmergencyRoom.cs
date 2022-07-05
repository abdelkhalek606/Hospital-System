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
    public partial class DoctorEmergencyRoom : Form
    {
        Controller controllerObj;
        public DoctorEmergencyRoom()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = new DataTable();
            dt = controllerObj.gitAvalibleRoom();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Id";

            DataTable dt2 = new DataTable();
            dt2 = controllerObj.SelectAllpatients();
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "username";

        }

        private void DoctorEmergencyRoom_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1==null || comboBox2 == null)
            {
                MessageBox.Show("Select patient user name and romm id");
                return;
            }

            int SSN = controllerObj.gitPatientSSN(comboBox2.Text.ToString());   

            int q = controllerObj.EmergencyRoom(Convert.ToInt32(comboBox1.Text.ToString()),SSN);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
