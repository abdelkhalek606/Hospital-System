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
    public partial class adminupdatepatientsandrelatives : Form
    {
        Controller controllerObj;
        public adminupdatepatientsandrelatives()
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable relaiddt = controllerObj.Selectrelativeid();
            comboBoxrela.DataSource = relaiddt;
            comboBoxrela.DisplayMember = "relative_ssn";

            DataTable patiddt = controllerObj.Selectpatid();
            comboBoxpat.DataSource = patiddt;
            comboBoxpat.DisplayMember = "SSN";

            relativephone.Maximum = Int32.MaxValue;
            relativephone.Minimum = 0;

            patphone.Maximum = Int32.MaxValue;
            patphone.Minimum = 0;
        }

        private void adminupdatepatientsandrelatives_Load(object sender, EventArgs e)
        {

            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
            groupBox2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void patdateinbut_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(comboBoxpat.Text);
            int r = controllerObj.updatePatbirth(number1, patientbirthday.Value);
            MessageBox.Show("updated successfully");
        }

        private void patphonebutton_Click(object sender, EventArgs e)
        {
            if (patphone.Value == 0)
            {
                MessageBox.Show("please insert all the data");
            }
            else
            {
                int number2 = Convert.ToInt32(Math.Round(patphone.Value, 0));
                int number1 = Int32.Parse(comboBoxpat.Text);
                int r = controllerObj.updatepatientphone(number1, number2);
                MessageBox.Show("updated successfully");
            }
        }

        private void patnamebutton_Click(object sender, EventArgs e)
        {
            if (patfname.Text == "" || patmname.Text == "" || patlname.Text == "")
            {
                MessageBox.Show("please insert all the data");
            }
            else
            {

                int number1 = Int32.Parse(comboBoxpat.Text);
                int r = controllerObj.updatepatientname(number1, patfname.Text.ToString(), patmname.Text.ToString()
                    , patlname.Text.ToString());
                MessageBox.Show("updated successfully");
            }
        }

        private void patsexbutton_Click(object sender, EventArgs e)
        {
            if (patsex.Text == "")
            {
                MessageBox.Show("please insert all the data");
            }
            else
            {

                int number1 = Int32.Parse(comboBoxpat.Text);
                int r = controllerObj.updatepatientsex(number1, patsex.Text.ToString());
                MessageBox.Show("updated successfully");
            }
        }

        private void relativenameupdatebutton_Click(object sender, EventArgs e)
        {
            if (textBoxrelaname.Text == "")
            { MessageBox.Show("please insert all the data"); }
            else
            {
                int number1 = Int32.Parse(comboBoxrela.Text);
                int r = controllerObj.updaterelaname(number1, textBoxrelaname.Text.ToString());
                MessageBox.Show("updated successfully");
            }
        }

        private void updaterelativebday_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(comboBoxrela.Text);
            int r = controllerObj.updaterelabirth(number1, relativebirthday.Value);
            MessageBox.Show("updated successfully");
        }

        private void updaterelativesexbutton_Click(object sender, EventArgs e)
        {
            if (relativesex.Text == "")
            { MessageBox.Show("please insert all the data"); }
            else
            {
                int number1 = Int32.Parse(comboBoxrela.Text);
                int r = controllerObj.updaterelasex(number1, relativesex.Text.ToString());
                MessageBox.Show("updated successfully");
            }
        }

        private void updaterelativephonebutton_Click(object sender, EventArgs e)
        {
            if (relativephone.Text == "")
            { MessageBox.Show("please insert all the data"); }
            else
            {
                int number2 = Convert.ToInt32(Math.Round(relativephone.Value, 0));
                int number1 = Int32.Parse(comboBoxrela.Text);
                int r = controllerObj.updaterelaphone(number1, number2);
                MessageBox.Show("updated successfully");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            adminupdatedata A = new adminupdatedata();  
            A.Show();
        }
    }
}
