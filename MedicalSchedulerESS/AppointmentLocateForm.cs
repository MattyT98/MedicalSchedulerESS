using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalSchedulerESS
{
    public partial class AppointmentLocateForm : Form
    {
        static List<AppointmentReference> appointments = new List<AppointmentReference>();

        public AppointmentLocateForm()
        {
            InitializeComponent();
            InitializeList();
        }

        private void InitializeList()
        {
            for(int i = 0; i < 50; i++)
            {
                DateTime d = new DateTime(1998, 09, 24);                
                AppointmentReference a = new AppointmentReference("123-456-789", "1234" + i.ToString(), d, "S11 9AY", "John" + i.ToString(), "Doe");
                appointments.Add(a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool reference = false;
            bool code = false;
            bool dob = false;
            bool postcode = false;
            string name = "";
            //Validation
            foreach (AppointmentReference a in appointments)
            {
                if (a.reference == reference_textBox.Text)
                    reference = true;

                if (a.code == code_textBox.Text.ToString())
                    code = true;
                
                string selectedDate = dob_dateTimePicker.Value.ToShortDateString();
                string comparingDate = a.dob.ToShortDateString();
                if (comparingDate == selectedDate)
                    dob = true;

                if (a.postcode == postcode_textBox.Text)
                    postcode = true;


                if ((a.reference == reference_textBox.Text) && (comparingDate == selectedDate) && (a.code == code_textBox.Text.ToString()) && (a.postcode == postcode_textBox.Text))
                    name = a.firstName + " " + a.lastName;
               
            }

            //More Validation
            if (reference == false)
            {
                MessageBox.Show("Refernce Not Found");
            } else if (code == false)
            {
                MessageBox.Show("Code Not Found");
            } else if (dob == false)
            {
                MessageBox.Show("DOB Does Not Match Records");
            } else if( postcode == false)
            {
                MessageBox.Show("Postcode Does Not Match Records");
            } else
            {   //All Validation Passed - Open next form
                this.Hide();
                ScheduleAppointmentForm ScheduleAppointment = new ScheduleAppointmentForm(this, name);
                ScheduleAppointment.Show();
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
