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
    public partial class DoctorQ : Form
    {
        string user = "";
        string qA = "";
        string A = "";
        int SSN = 0;
        int id = 0;
        Controller controllerObj; 
        public DoctorQ(string u)
        {
            InitializeComponent();
            user = u; 
           
            controllerObj = new Controller();
            id = controllerObj.gitDocID(u);
            button1.Enabled = false;
            DataTable dt = new DataTable();
            dt = controllerObj.ViewDocQ(user);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             A = ansmessege.Text.ToString();
            int q = controllerObj.insertAns(SSN, id , qA , A);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                qA  = row.Cells["question"].Value.ToString();

                SSN = (int)row.Cells["sender_ssn"].Value;
                 button1.Enabled = true;
            }
        }


        private void DoctorQ_Load(object sender, EventArgs e)
        {
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

        private void ansmessege_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Doctor doctor = new Doctor(user);
            doctor.Show();
        }
    }
}
