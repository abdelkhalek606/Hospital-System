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
    public partial class AskQuestion : Form
    {
        Controller controllerObj;
        int pssn;
        string user = "";
        public AskQuestion(string u)
        {
            InitializeComponent();
            controllerObj = new Controller() ;
            user = u;
            pssn = controllerObj.gitPatientSSN(user);
            DataTable dt = controllerObj.Selectdoc(pssn);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            DataTable dt2 = controllerObj.getQuestion(pssn);
            dataGridView1.DataSource = dt2;

        }

        private void AskQuestion_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(208, 211, 238);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ansmessege == null)
            {
                MessageBox.Show("please enter The question ");
                return;
            }
            int docid = controllerObj.Selectdocid(comboBox1.Text, pssn);

            int q = controllerObj.AskQuestion(pssn, docid, ansmessege.Text.ToString());
            MessageBox.Show("Wait for Response !!");
        }

        private void ansmessege_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Patient patient = new Patient(user);
            patient.Show();
        }
    }
}
