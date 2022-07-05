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
    public partial class Doctor : Form
    {
        string usre = "";
        Controller controllerObj;
        public Doctor(string u)
        {
            InitializeComponent();
            controllerObj = new Controller();
            usre = u;
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

        }

        private void showschedule_Click(object sender, EventArgs e)
        {
            DoctorSchadual D = new DoctorSchadual(usre);
            D.Show();
        }

        private void answermessege_Click(object sender, EventArgs e)
        {
            this.Close();
            DoctorQ doctorQ = new DoctorQ(usre);    
            doctorQ.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorEmergencyRoom doctorEmergencyRoom = new DoctorEmergencyRoom();
            doctorEmergencyRoom.Show();
            
        }

        private void delet_Click(object sender, EventArgs e)
        {
            int id = controllerObj.gitDocID(usre);
            DeleteApp deleteApp = new DeleteApp(id);
            deleteApp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Profile profile = new Profile("doc", usre);
            profile.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login("Doctor");
            login.Show();
        }
    }
}
