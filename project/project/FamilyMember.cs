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
  
    public partial class FamilyMember : Form
    {
        Controller controllerObj;
        string T = "";
        string U = "";
        public FamilyMember(string user, string type)
        {
            InitializeComponent();
            T= type; U= user;   
            controllerObj = new Controller();
            if (type == "Recep")
            {
                
                DataTable dt = controllerObj.SelectAllpatients();
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "username";
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("username");
                dt.Rows.Add(user);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "username";
            }

        }

        private void FamilyMember_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);     
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string u = comboBox1.Text.ToString();   
            if (u == "")
            {
                return;
            }
            else
            {
                this.Close();
                AddFamilyMember A = new AddFamilyMember(u, U,T);
                A.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            if(T== "Recep")
            {

                Receptionist R = new Receptionist(U);
                R.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string u = comboBox1.Text.ToString();

            if (u == "")
            {
                return;
            }
            else
            {
                this.Close();
                ShowFamilyMember A = new ShowFamilyMember(u, U, T);
                A.Show();
            }
            
        }
    }
}
