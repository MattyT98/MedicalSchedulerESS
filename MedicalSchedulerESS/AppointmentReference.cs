using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalSchedulerESS
{
    public class AppointmentReference
    {
        public string reference { get; set; }
        public string code { get; set; }
        public DateTime dob { get; set; }
        public string postcode { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public AppointmentReference(string reference, string code, DateTime dob, string postcode, string firstName, string lastName)
        {
            this.reference = reference;
            this.code = code;
            this.dob = dob;
            this.postcode = postcode;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
