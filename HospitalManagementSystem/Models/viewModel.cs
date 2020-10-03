using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagementSystem.Models
{
    public class viewModel
    {
        public int docID { get; set; }
        public int patientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public Nullable<long> Phone { get; set; }
        public Nullable<long> Mobile { get; set; }
        public byte[] Picture { get; set; }
        public string Specialist { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string BloodGroup { get; set; }
        public string Status { get; set; }
        public int documentID { get; set; }
        public string patientName { get; set; }
        public string fileattachment { get; set; }
        public string filename { get; set; }
        public string filetype { get; set; }
        public string doctorName { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> dateOfTime { get; set; }
      



    }
}