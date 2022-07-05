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
    public partial class Patient : Form
    {
        string user = "";
        public Patient(string u)
        {
            InitializeComponent();
            user = u;
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            TopRatedDoctor topRatedDoctor = new TopRatedDoctor(user);   
            topRatedDoctor.Show();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            bookappointmint b = new bookappointmint(user);  
            b.Show();   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rate rate = new Rate(user); 
                rate.Show();    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            PatientFamilyMember patientFamilyMember = new PatientFamilyMember(user);    
            patientFamilyMember.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login("Patient");
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Profile profile =new Profile("pat",user);
            profile.Show(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            AskQuestion askQuestion = new AskQuestion(user);
            askQuestion.Show();
        }
    }
}
