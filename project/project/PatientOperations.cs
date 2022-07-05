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
    public partial class PatientOperations : Form
    {
        string user = "";
        public PatientOperations( string U)
        {
            InitializeComponent();
            user = U;   
        }

        private void PatientOperations_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();   
            AddPation addPation = new AddPation(user);
            addPation.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Viset V = new Viset("enter");
            V.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Viset V = new Viset("Exit");
            V.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Receptionist  R = new Receptionist(user);
            R.Show();

        }
    }
}
