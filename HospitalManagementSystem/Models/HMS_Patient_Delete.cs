using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagementSystem.Models
{
    public class HMS_Patient_Delete
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string BloodGroup { get; set; }
        public Nullable<long> Mobile { get; set; }
        public byte[] Picture { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string Status { get; set; }
    }
}