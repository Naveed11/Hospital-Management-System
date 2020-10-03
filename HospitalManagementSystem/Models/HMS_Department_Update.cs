using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagementSystem.Models
{
    public class HMS_Department_Update
    {
        public string departName { get; set; }

        public string departDescription { get; set; }
        public int Status { get; set; }
    }
}