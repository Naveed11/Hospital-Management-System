using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagementSystem.Controllers
{
    public class PrescriptionController : Controller
    {
        // GET: Prescription
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddPatientCaseStudy()
        {
            return View();
        }
        public ActionResult PatientCaseStudyList()
        {
            return View();
        }
        public ActionResult PrescriptionList()
        {
            return View();
        }
    }
}