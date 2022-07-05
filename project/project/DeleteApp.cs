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
    public partial class DeleteApp : Form
    {
        Controller controllerObj;
        int ID=0;
        public DeleteApp(int id)
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = new DataTable();
            dt = controllerObj.getDocApDay(id);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "day";
            ID = id;
        }

        private void DeleteApp_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //////////////
            ///
            DataTable dataTable = new DataTable();
            dataTable = controllerObj.getDocApp(ID, comboBox1.Text.ToString());


            comboBox2.DataSource = dataTable;
            comboBox2.DisplayMember = "starttime" ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int q =controllerObj.deleteApointment(ID,comboBox1.Text.ToString(),comboBox2.Text.ToString());  
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
