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
    public partial class Ambulance : Form
    {
        Controller controllerObj;
        public Ambulance()
        {
            InitializeComponent();
           controllerObj = new Controller();
            DataTable dt = new DataTable();
            dt = controllerObj.gitAmbulanceOut();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Id";   
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Ambulance_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1 == null)
            {
                MessageBox.Show("Choose an ambulance");
                return;
            }
            int q= controllerObj.EditAmbulance(Convert.ToInt32(comboBox1.Text));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
