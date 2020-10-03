using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagementSystem.Controllers
{
    public class HospitalActivitiesController : Controller
    {
        // GET: HospitalActivities
        NaveedEntities db = new NaveedEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddBirthReport()
        {
            return View(); 
                 
        }

        public ActionResult BirthReport()
        {
            return View();
        }

        public ActionResult AddDeathReport()
        {
            return View();
        }

        public ActionResult DeathReport()
        {
            return View();
        }

        public ActionResult AddOperationReport()
        {
            return View();
        }
        public ActionResult OperationReport()
        {
            return View();
        }

        public ActionResult AddMedicineCategory()
        {
            return View();
        }


        public ActionResult MedicineCategoryList()
        {
            return View();
        }

        public ActionResult AddMedicine()
        {
            return View();
        }

        public ActionResult MedicineList()
        {
            return View();
        }


        public ActionResult AddBloodGroup()
        {
            return View();
        }

        public ActionResult BloodGroupList()
        {
            return View();
        }
        public ActionResult GetRecordFromBloodGroup()
        {
            var list = db.Database.SqlQuery<HMS_BloodGroup>("select * from HMS_BloodGroup").ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddBloodGroupRecord(string bloodGroup)
        {
            var data = db.Database.SqlQuery<HMS_BloodGroup>("insert into HMS_BloodGroup(bloodGroup) values('"+ bloodGroup + "') ").ToList();
            return Json("Added",JsonRequestBehavior.AllowGet);
        }

        public ActionResult BloodGroupEditPage()
        {
            return View();
        }
        public ActionResult BloodGroupGetRecordByID(string last_segment)
        {
            var data = db.Database.SqlQuery<HMS_BloodGroup>("select * from HMS_BloodGroup where id = "+last_segment).ToList();
            return Json(data,JsonRequestBehavior.AllowGet);
        }
        public ActionResult BloodGroupUpdateRecord(string bloodgroup,int last_segment)
        {
            var data = db.Database.SqlQuery<HMS_BloodGroup>("update HMS_BloodGroup set bloodGroup = '"+bloodgroup+"' where id = "+last_segment).ToList();
            return Json("",JsonRequestBehavior.AllowGet);
        }



    }
}