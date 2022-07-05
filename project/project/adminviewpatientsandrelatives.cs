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
    public partial class adminviewpatientsandrelatives : Form
    {
        Controller controllerObj;
        public adminviewpatientsandrelatives()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void patientgridbutt_Click(object sender, EventArgs e)
        {
            DataTable petdt = controllerObj.SelectAllpatients();
            patGridView.DataSource = petdt;
            patGridView.Refresh();
        }

        private void relativegridbutt_Click(object sender, EventArgs e)
        {
            DataTable reladt = controllerObj.SelectAllrelatives();
            patGridView.DataSource = reladt;
            patGridView.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            adminviewdata a = new adminviewdata();
            a.Show();
        }

        private void adminviewpatientsandrelatives_Load(object sender, EventArgs e)
        {
            patGridView.BorderStyle = BorderStyle.None;
            patGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            patGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            patGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(208, 211, 238);
            patGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            patGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            patGridView.EnableHeadersVisualStyles = false;
            patGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            patGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            patGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void patGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
