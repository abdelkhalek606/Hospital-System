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
    public partial class PatientFamilyMember : Form
    {
        string user = "";
        public PatientFamilyMember(string u)
        {
            InitializeComponent();
            user = u;   
        }

        private void PatientFamilyMember_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddFamilyMember A = new AddFamilyMember(user, "", "pat");
            A.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ShowFamilyMember A = new ShowFamilyMember(user, "", "pat");
            A.Show();
        }
    }
}
