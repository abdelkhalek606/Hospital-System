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
    public partial class adminupdatedata : Form
    {
        public adminupdatedata()
        {
            InitializeComponent();
        }

        private void mangmentbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            adminupdatemangingstaff i = new adminupdatemangingstaff();
            i.Show();
        }

        private void patientbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            adminupdatepatientsandrelatives p = new adminupdatepatientsandrelatives();
            p.Show();
        }

        private void medicalstaffupdate_Click(object sender, EventArgs e)
        {
            this.Close();
            adminupdatemedical m = new adminupdatemedical();
            m.Show();
        }

        private void passwordsbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            adminpasswordmanagement u = new adminpasswordmanagement();
            u.Show();
        }

        private void adminupdatedata_Load(object sender, EventArgs e)
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
