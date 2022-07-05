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
    public partial class TopRatedDoctor : Form
    {
        Controller controllerObj;
        string docname = "";
      
        string depname = "";
        string user = "";
        public TopRatedDoctor(string u)
        {
            controllerObj = new Controller();
            InitializeComponent();
            DataTable dt;
            dt = controllerObj.Selecttopratedoctor();
            dataGridView1.DataSource = dt;
            button1.Enabled = false;
            user = u;
        }

        private void TopRatedDoctor_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                docname = row.Cells["Doctor Name"].Value.ToString();
                depname = row.Cells["specialization"].Value.ToString();
                
                button1.Enabled = true;
            }
           

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            bookappointmint f = new bookappointmint(user ,docname, depname,"gg");
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Patient p = new Patient(user);
            p.Show();
        }
    }
}
