using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagementSystem.Models
{
    public class HMS_Document_Delete
    {
        public string patientName { get; set; }
        public string fileattachment { get; set; }
        public string filename { get; set; }
        public string filetype { get; set; }
        public string doctorName { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> dateOfTime { get; set; }
    }
}