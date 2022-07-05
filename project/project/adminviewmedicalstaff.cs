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
    public partial class adminviewmedicalstaff : Form
    {
        Controller controllerObj;
        public adminviewmedicalstaff()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void adminviewmedicalstaff_Load(object sender, EventArgs e)
        {
            GridView1.BorderStyle = BorderStyle.None;
            GridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(208, 211, 238);
            GridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            GridView1.EnableHeadersVisualStyles = false;
            GridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            GridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            GridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void docgridbutt_Click(object sender, EventArgs e)
        {

            DataTable docdt = controllerObj.SelectAlldoctors();
            GridView1.DataSource = docdt;
            GridView1.Refresh();
        }

        private void depgridbutt_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAlldeps();
            GridView1.DataSource = dt;
            GridView1.Refresh();
        }

        private void ambgridbutt_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllambulances();
            GridView1.DataSource = dt;
            GridView1.Refresh();
        }

        private void nursegridbutt_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllnurses();
            GridView1.DataSource = dt;
            GridView1.Refresh();
        }

        private void disproombutt_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllrooms();
            GridView1.DataSource = dt;
            GridView1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            adminviewdata a = new adminviewdata();
            a.Show();
        }

        private void GridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
