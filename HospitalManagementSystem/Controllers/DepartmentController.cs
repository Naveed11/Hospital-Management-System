using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagementSystem.Controllers
{
    public class DepartmentController : Controller
    {
        NaveedEntities db = new NaveedEntities();
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddDepartment()
        {
            
            return View();
        }

        public ActionResult DepartmentList()
        {
            return View();
        }

        public ActionResult AddRecord(string departmentName,string description,string statusRadio)
        {
            var data = db.Database.SqlQuery<HMS_Department_Update>("insert into HMS_Department(departName,departDescription,Status)values('"+departmentName+"','"+description+"','"+ statusRadio + "')").ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ListAll()
        {
            var list = db.Database.SqlQuery<HMS_Department>("select * from HMS_Department").ToList();
            return Json(list,JsonRequestBehavior.AllowGet);
        }

        public ActionResult EditPage()
        {
            return View();
        }
        public ActionResult GetRecordById(int final_value)
        {
            var data = db.Database.SqlQuery<HMS_Department>("select * from HMS_Department where departID= "+final_value).ToList();
            return Json(data,JsonRequestBehavior.AllowGet);
        }

        public ActionResult UpdateRecord(string departmentName,string description,int radioStatus, int final_value)
        {
            var data = db.Database.SqlQuery<HMS_Department_Update>("update HMS_Department set  departName ='"+departmentName+ "' ,departDescription = '"+description+ "' , Status = '"+ radioStatus + "' where departID = "+final_value).ToList();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteRecord(int departID)
        {
            var data = db.Database.SqlQuery<HMS_Department_Update>("delete from HMS_Department where departID ="+departID).ToList();

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}