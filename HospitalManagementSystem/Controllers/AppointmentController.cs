using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagementSystem.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddAppointment()
        {
            return View();
        }

        public ActionResult AppointmentList()
        {
            return View();
        }
        public ActionResult AssignbyAll()
        {
            return View();
        }

        public ActionResult AssignbyDoctor()
        {
            return View();
        }

        public ActionResult AssignbyRepresentative()
        {
            return View();
        }
    }
}