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
    public partial class bookappointmint : Form
    {
        string where = "";
        string user = "";
        int pssn;
        double[,] possiplappointment;
        int countdayes;
        int[] apointinday;
        string[] possiboldayes;
        Controller controllerObj;
        public bookappointmint(string u , string name = "", string depname = "", string w= "")
        {
            InitializeComponent();
            where = w;
            controllerObj = new Controller();
            user = u;
            pssn = controllerObj.gitPatientSSN(u);
            DataTable dt1 = controllerObj.SelectDepname();
            departmentcombobox.DataSource = dt1;
            departmentcombobox.DisplayMember = "Dname";
            string s1 = departmentcombobox.Text;

            dt1 = controllerObj.Selectdocname(s1);
            user = u;
            if (name != "")
            {

                departmentcombobox.Text = depname;
                doctorcomboBox.Text = name;
            }
        }

            private void bookappointmint_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void departmentcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = departmentcombobox.Text;
            DataTable dt = controllerObj.Selectdocname(s);
            doctorcomboBox.DataSource = dt;
            doctorcomboBox.DisplayMember = "name";
            doctorcomboBox.Refresh();
        }

        private void doctorcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = doctorcomboBox.Text;
            DataTable dt = controllerObj.Selectappointment(s);
            if (dt != null)
            {



                string[,] y = new string[dt.Rows.Count, dt.Columns.Count];
                int i2 = 0;
                int c2 = 0;
                int countexisingappointment = dt.Rows.Count;
                foreach (DataRow row in dt.Rows)
                {
                    for (int k = 0; k < dt.Columns.Count; k++)
                    {
                        y[c2, i2] = row.ItemArray.GetValue(k).ToString();
                        i2++;
                    }
                    i2 = 0;
                    c2++;
                }
                dt = controllerObj.Selectschadul(s);

                string[,] x = new string[dt.Rows.Count + 5, dt.Columns.Count + 5];
                int i = 0;
                int c = 0;
                foreach (DataRow row in dt.Rows)
                {
                    for (int k = 0; k < dt.Columns.Count; k++)
                    {
                        x[c, i] = row.ItemArray.GetValue(k).ToString();
                        i++;
                    }
                    i = 0;
                    c++;
                }
                countdayes = dt.Rows.Count;
                possiboldayes = new string[countdayes + 3];
                apointinday = new int[countdayes];
                int counter2 = 0;
                possiplappointment = new double[countdayes, 24];
                for (int k = 0; k < countdayes; k++)
                {

                    apointinday[k] = 0;
                    for (double k2 = int.Parse(x[k, 0]); k2 < int.Parse(x[k, 1]); k2 = k2 + .5)
                    {

                        apointinday[k] = apointinday[k] + 1;
                        possiplappointment[k, counter2] = k2;
                        counter2++;
                    }
                    possiboldayes[k] = x[k, 2];
                    counter2 = 0;
                }

                int ino = 0;

                for (int counter = 0; counter < countdayes; counter++)
                {

                    for (int count = 0; count < apointinday[counter]; count++)
                    {
                        for (int cnt = 0; cnt < countexisingappointment; cnt++)
                        {
                            if (x[counter, 2] == y[cnt, 2] && possiplappointment[counter, count] == double.Parse(y[cnt, 0]))
                            {

                                possiplappointment[counter, count] = -1;
                            }
                            ino++;

                        }
                        ino = 0;
                    }

                }

                int sumpossiblappointment = 0;
                for (int cn = 0; cn < countdayes; cn++)
                    for (int cn2 = 0; cn2 < apointinday[cn]; cn2++)
                        sumpossiblappointment++;

                daycomboBox.Items.Clear();
                string appointment;
                for (int counter = 0; counter < countdayes; counter++)
                {


                    appointment = possiboldayes[counter];
                    daycomboBox.Items.Add(appointment);





                }

                daycomboBox.Refresh();

            }
        }

        private void daycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string appointment;
            string[] y = new string[3];

            for (int counter = 0; counter < countdayes; counter++)
            {
                if (possiboldayes[counter] != daycomboBox.Text)
                {
                }
                else
                {

                    for (int count = 0; count < apointinday[counter]; count++)
                    {
                        if (possiplappointment[counter, count] > 0)
                        {
                            string x = possiplappointment[counter, count].ToString();
                            if (x.Contains("."))
                            {
                                y = x.Split('.');
                                appointment = "from " + y[0] + ":30" + " to " + (possiplappointment[counter, count] + .50).ToString();
                                appointmentcomboBox.Items.Add(appointment);

                            }
                            else
                            {
                                appointment = "from " + x + " to " + (possiplappointment[counter, count]).ToString() + ":30";
                                appointmentcomboBox.Items.Add(appointment);
                            }




                        }



                    }
                }
            }

            appointmentcomboBox.Refresh();
        }

        private void appointmentcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bookbutton_Click(object sender, EventArgs e)
        {

            string[] appoin = new string[6];
            string[] appoin2 = new string[3];
            string t1;
            string t2;

            if (doctorcomboBox.Text == "" || daycomboBox.Text == "" || appointmentcomboBox.Text == "" || departmentcombobox.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else

            {

                int clinicid = controllerObj.Selectclinicid(doctorcomboBox.Text);
                string x = appointmentcomboBox.Text;
                appoin = x.Split(' ');
                if (appoin[1].Contains(":"))
                {
                    appoin2 = appoin[1].Split(':');
                    t1 = appoin2[0] + ".5";
                    t2 = appoin[3];
                }
                else
                {
                    appoin2 = appoin[3].Split(':');
                    t2 = appoin2[0] + ".5";
                    t1 = appoin[1];
                }

                int r = controllerObj.Insertappointment(t1, t2, clinicid, pssn, daycomboBox.Text);

                if (r == 0)
                {
                    MessageBox.Show("The regestration is feild");

                }
                else
                {
                    MessageBox.Show("you book successfully");

                    int docid = controllerObj.Selectdocid(doctorcomboBox.Text,pssn);

                    controllerObj.Insertcare(docid, pssn);
                }

            }

            daycomboBox.Items.Clear();
            appointmentcomboBox.Items.Clear();
            daycomboBox.Text = " ";
            appointmentcomboBox.Text = " ";


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (where == "")
            {
                this.Close();
                Patient P = new Patient(user);
                P.Show();
            }
            else
            {
                this.Close();
                TopRatedDoctor topRatedDoctor = new TopRatedDoctor(user);
                topRatedDoctor.Show();
            }
            
        }
    }
}
