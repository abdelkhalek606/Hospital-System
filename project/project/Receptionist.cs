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
    public partial class Receptionist : Form
    {
        String User = "";
        public Receptionist(string user)
        {
            InitializeComponent();
            this.User = user;   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();    
            FamilyMember F = new FamilyMember(User, "Recep");
            F.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientOperations Pat = new PatientOperations( User);
            Pat.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ambulance ambulance = new Ambulance();  
            ambulance.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            RoomsRequests roomsRequests = new RoomsRequests(User);  
            roomsRequests.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login("Recep");
            l.Show();       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Profile profile =new Profile ("Rec", User);
            profile.Show();
        }
    }
}
