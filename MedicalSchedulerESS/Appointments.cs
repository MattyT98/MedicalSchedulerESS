using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalSchedulerESS
{
    public class Appointments
    {
        public string appointmentDate { get; set; }
        public string appointmentTime { get; set; }
        public Appointments(string appointmentDate, string appointmentTime)
        {
            this.appointmentDate = appointmentDate;
            this.appointmentTime = appointmentTime;
        }
    }
}
