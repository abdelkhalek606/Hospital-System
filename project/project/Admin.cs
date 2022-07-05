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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            adminadd a = new adminadd();
            a.Show();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            this.Close ();
            adminupdatedata u = new adminupdatedata();
            u.Show();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            this.Close();
            admindelete d = new admindelete();
            d.Show();
        }

        private void adminview_Click(object sender, EventArgs e)
        {
            this.Close();
            adminviewdata v = new adminviewdata();
            v.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Login L = new Login("Admin");
            L.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
