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
    public partial class adminaddmedicalstaff : Form
    {
        Controller controllerObj;
        public adminaddmedicalstaff()
        {
          
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectDepnum();
            doctordno.DataSource = dt;
            doctordno.DisplayMember = "Dnumber";
            //DataTable dt2 = controllerObj.Selectclinicid();
            // doctordno.DataSource = dt2;
            // doctordno.DisplayMember = "id";
            DataTable dt3 = controllerObj.Selectdocid();
            clincsdocid.DataSource = dt3;
            clincsdocid.DisplayMember = "id";

            doctorid.Maximum = Int32.MaxValue;
            doctorid.Minimum = 0;

            roomid.Maximum = Int32.MaxValue;
            roomid.Minimum = 0;

            ambulanceid.Maximum = Int32.MaxValue;
            ambulanceid.Minimum = 0;

            nurseid.Maximum = Int32.MaxValue;
            nurseid.Minimum = 0;

            clincid.Maximum = Int32.MaxValue;
            clincid.Minimum = 0;
        }

        private void doctorbutton_Click(object sender, EventArgs e)
        {
            if (doctorid.Value == 0 || doctorname.Text == "" || docusername.Text == "" || docpass.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            //

            int number;

            bool success = int.TryParse(docpass.Text.ToString(), out number);
            if (!success)
            {
                MessageBox.Show("please enter correct password ex:1,2,3");
                return;
            }
            else
            {
                int number1 = Int32.Parse(doctordno.Text);

                int count = Convert.ToInt32(Math.Round(doctorid.Value, 0));
                int r = controllerObj.Insertdoctor(count, number1, doctorname.Text.ToString(), docusername.Text.ToString(), Int32.Parse(docpass.Text));
                MessageBox.Show("inserted successfully");
            }
        }

        private void roombutton_Click(object sender, EventArgs e)
        {
            if (roomid == null )//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int count = Convert.ToInt32(Math.Round(roomid.Value, 0));
                int r = controllerObj.Insertroom(count);
                MessageBox.Show("inserted successfully");
            }
        }

        private void ambulancebutton_Click(object sender, EventArgs e)
        {
            if (ambulanceid == null)//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int count = Convert.ToInt32(Math.Round(ambulanceid.Value, 0));
                int r = controllerObj.Insertambulance(count);
                MessageBox.Show("inserted successfully");
            }
        }

        private void clinicbutton_Click(object sender, EventArgs e)
        {
            if (clincid == null)//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int number = Int32.Parse(clincsdocid.Text);
                int count = Convert.ToInt32(Math.Round(clincid.Value, 0));
                int r = controllerObj.Insertclinc(count, number);
                MessageBox.Show("inserted successfully");
            }
        }

        private void nursebutton_Click(object sender, EventArgs e)
        {

            if (nurseid == null || nursename == null)//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int count = Convert.ToInt32(Math.Round(nurseid.Value, 0));
                int r = controllerObj.Insertnurse(nursename.Text.ToString(), count);
                MessageBox.Show("inserted successfully");
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void adminaddmedicalstaff_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
            groupBox2.BackColor = Color.FromArgb(100, 0, 0, 0);
            groupBox3.BackColor = Color.FromArgb(100, 0, 0, 0);
            groupBox4.BackColor = Color.FromArgb(100, 0, 0, 0);
            groupBox5.BackColor = Color.FromArgb(100, 0, 0, 0);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            adminadd A = new adminadd();
            A.Show();
        }

        private void roomid_ValueChanged(object sender, EventArgs e)
        {

        }

        private void docpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
