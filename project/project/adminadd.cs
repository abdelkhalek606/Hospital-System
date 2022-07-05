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
    public partial class adminadd : Form
    {
        public adminadd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            adminaddmanagmentstaff am = new adminaddmanagmentstaff();
            am.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            adminaddmedicalstaff ad = new adminaddmedicalstaff();
            ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            adminaddpatientsandrelatives ap = new adminaddpatientsandrelatives();
            ap.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void adminadd_Load(object sender, EventArgs e)
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
