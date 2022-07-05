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
    public partial class ShowFamilyMember : Form
    {
        string US = "";
        string TS = "";
        Controller controllerObj;
        int SSN = 0;
        string user = "";
        public ShowFamilyMember(string u, string U, string T)
        {
            InitializeComponent();
            controllerObj = new Controller();
            US = U;
            TS = T;
            SSN = controllerObj.gitPatientSSN(u);
            user = u;
            DataTable dt = new DataTable();
            dt = controllerObj.SelectFamilyMember(user);
            dataGridView1.DataSource = dt;
        }

        private void ShowFamilyMember_Load(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            ///
            if (TS == "Recep")
            {
                this.Close();
                FamilyMember F = new FamilyMember(US, TS);
                F.Show();
            }

            if (TS == "pat")
            {
                this.Close();
                Patient p = new Patient(user);
                p.Show();

            }
        }
    }
}
