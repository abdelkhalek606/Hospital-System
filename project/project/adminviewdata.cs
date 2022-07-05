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
    public partial class adminviewdata : Form
    {
        public adminviewdata()
        {
            InitializeComponent();
        }

        private void mangmentbutton_Click(object sender, EventArgs e)
        {
            adminviewmanagmentstaff av = new adminviewmanagmentstaff();
            av.Show();
        }

        private void patientbutton_Click(object sender, EventArgs e)
        {
            adminviewpatientsandrelatives apr = new adminviewpatientsandrelatives();
            apr.Show();
        }

        private void medicalstaffview_Click(object sender, EventArgs e)
        {
            adminviewmedicalstaff ams = new adminviewmedicalstaff();
            ams.Show();
        }

        private void adminviewdata_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin admin = new Admin();
            admin.Show();
        }
    }
}
