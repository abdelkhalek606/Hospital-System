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
    public partial class adminviewmanagmentstaff : Form
    {
        Controller controllerObj;
        public adminviewmanagmentstaff()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void adminGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void recepgridbutt_Click(object sender, EventArgs e)
        {
            DataTable recepdt = controllerObj.SelectAllrecep();
            adminGridView.DataSource = recepdt;
            adminGridView.Refresh();
        }

        private void admingridbutt_Click(object sender, EventArgs e)
        {
            DataTable admindt = controllerObj.SelectAlladmin();
            adminGridView.DataSource = admindt;
            adminGridView.Refresh();
        }

        private void adminviewmanagmentstaff_Load(object sender, EventArgs e)
        {
            adminGridView.BorderStyle = BorderStyle.None;
            adminGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            adminGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            adminGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(208, 211, 238);
            adminGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            adminGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            adminGridView.EnableHeadersVisualStyles = false;
            adminGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            adminGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            adminGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            adminviewdata a = new adminviewdata();
            a.Show();
        }
    }
}
