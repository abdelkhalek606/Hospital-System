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
    public partial class Rate : Form
    {
        Controller controllerObj;
        int pssn;
        string user = "";
        public Rate(string u)
        {
            controllerObj = new Controller();
            user = u;  
            pssn = controllerObj.gitPatientSSN(user);
            InitializeComponent();
            DataTable dt;
            dt = controllerObj.Selectdoc(pssn);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            comboBox2.Items.Clear();
            comboBox2.Items.Add(5);
            comboBox2.Items.Add(4);
            comboBox2.Items.Add(3);
            comboBox2.Items.Add(2);
            comboBox2.Items.Add(1);
            comboBox2.Text = "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int docid = controllerObj.Selectdocid(comboBox1.Text,pssn);

            controllerObj.updaterate(int.Parse(comboBox2.Text), docid, pssn);
            MessageBox.Show("Thanks for Rating us !");
            this.Close();

        }

        private void Rate_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
