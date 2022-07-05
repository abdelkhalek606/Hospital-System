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
    public partial class Viset : Form
    {
        Controller ControllerObj;
        string tybe = "";
        public Viset(string T)
        {
            InitializeComponent();
            ControllerObj = new Controller();   
            tybe = T;
            DataTable dt = new DataTable();
            if (tybe == "enter")
            {
                dt = ControllerObj.getPatientOut(); ///
            }
            else
            {
                dt = ControllerObj.gitPatientIn();
            }
           
            
           
           
         
            comboBox1.DataSource = dt;  
            comboBox1.DisplayMember = "username";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Viset_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1 == null)
            {
                MessageBox.Show("choose a user name");
                return;
            }

           
            
            if(tybe == "enter")
            {
                int q= ControllerObj.addPatientVisit(comboBox1.Text.ToString(), dateTimePicker1.Value.ToString());  
            }
            else
            {
                int q = ControllerObj.addPatientOut(comboBox1.Text.ToString(), dateTimePicker1.Value.ToString());
            }
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
