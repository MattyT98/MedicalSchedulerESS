using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MedicalSchedulerESS
{
    public partial class ScheduleAppointmentForm : Form
    {
        readonly AppointmentLocateForm Identity;

        List<Appointments> availableAppointments = new List<Appointments>();
        bool appointmentBooked = false;
        string removedString = "";


        public ScheduleAppointmentForm(AppointmentLocateForm identity, string name)
        {
            InitializeComponent();
            InitialiseUser(name);
            InitialiseAppointments();
            Identity = identity;
        }

        private void InitialiseUser(string name)
        {
            patientName_textBox.Text = name; ;
            clinic_textBox.Text = "Cardiology";
        }
        private void InitialiseAppointments()
        {
            for (int i = 1; i < 10; i++)
            {
                Appointments a = new Appointments(i + "/05/22","12:00"); 
                availableAppointments.Add(a);         
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Identity.Show();
            this.Close();
        }

        private void viewAppointmentsDisplay()
        {
            for (int i = 0; i < availableAppointments.Count; i++)
            {
                availableAppointments_listBox.Items.Add(availableAppointments[i].appointmentDate + " : " + availableAppointments[i].appointmentTime);
            }
        }

        private void viewAppointments_button_Click(object sender, EventArgs e)
        {
            viewAppointmentsDisplay();
        }
        private void bookAppointment_button_Click(object sender, EventArgs e)
        {
            if (appointmentBooked != false)
            {
                MessageBox.Show("You Already Have an Appointment Booked, Please Check and Cancel If you Want To re-book");
            } else if (availableAppointments_listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select An Appointment");
            } else
            {
                string removelistitem = availableAppointments_listBox.SelectedItem.ToString();
                removedString = availableAppointments_listBox.SelectedItem.ToString();
                for (int n = availableAppointments_listBox.Items.Count - 1; n > -1; --n)
                {
                    if (availableAppointments_listBox.Items[n].ToString().Contains(removelistitem))
                    {
                        availableAppointments_listBox.Items.RemoveAt(n);
                    }
                }
                appointmentBooked = true;
                currentAppointment_textBox.Text = removedString;
            }
        }

        private void cancelAppointment_button_Click(object sender, EventArgs e)
        {
            if (appointmentBooked == true)
            {
                if (MessageBox.Show("Yes or no", "Confrim Cancellation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    availableAppointments_listBox.Items.Clear();
                    viewAppointmentsDisplay();
                    currentAppointment_textBox.Text = "";
                    appointmentBooked = false;
                }
            }
            else
            {
                MessageBox.Show("No Appointment is currently booked");
            }
        }
    }
}
