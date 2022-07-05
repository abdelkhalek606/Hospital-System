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
    public partial class RoomsRequests : Form
    {
        Controller controllerObj;
        string user = "";
        public RoomsRequests(string U)
        {
           
            InitializeComponent();
            user = U;
            controllerObj = new Controller();
            DataTable dt = new DataTable(); 
            dt = controllerObj.gitRequestedRooms(); 
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "room_id";
        }

        private void RoomsRequests_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
            {
                return;
            }
            else
            {
                DataTable dt = new DataTable();
                dt = controllerObj.gitPatientWhoRequestedRoom(Convert.ToInt32(comboBox1.Text.ToString()));
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "patient_requst";
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int q = controllerObj.joinRoom(Convert.ToInt32(comboBox1.Text.ToString()), Convert.ToInt32(comboBox2.Text.ToString()));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Receptionist R = new Receptionist(user);
            R.Show();
        }
    }
}
