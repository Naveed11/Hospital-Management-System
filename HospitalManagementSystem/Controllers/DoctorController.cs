using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagementSystem.Controllers
{
    public class DoctorController : Controller
    {
        NaveedEntities db = new NaveedEntities();

        // GET: Doctor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddDoctor()
        {
            
            ViewBag.departmentList = new SelectList(db.HMS_Department, "departName", "departName");
            ViewBag.bloodGroup = new SelectList(db.HMS_BloodGroup, "bloodGroup", "bloodGroup");

            return View();
        }

        public ActionResult DoctorList()
        {
            return View();
        }
        public ActionResult AddRecord(string firstname, string lastname, string email,string password,string designation,string departmentList,string address,string phone,string mobile,string picture,string specialist,string date_of_birth,string sex,string bloodGroup,string status)
        {
            var data = db.Database.SqlQuery<HMS_Doctor>("insert into HMS_Doctor(FirstName,LastName,Email,Password,Designation,Department,Address,Phone,Mobile,Picture,Specialist,DateOfBirth,Sex,BloodGroup,Status)values('" + firstname + "','" + lastname + "','" + email + "','" + password + "','" + designation + "','" + departmentList + "','" + address + "','" + phone + "','" + mobile + "','" + picture + "','" + specialist + "','" + date_of_birth + "','" + sex + "','" + bloodGroup + "','" + status + "')").ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ListAll()
        {
            var list = db.Database.SqlQuery<viewModel>("select * from HMS_Doctor").ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public ActionResult DeleteRecord(IEnumerable<int> docID)
        {
            foreach (int id in docID)
            {
                var list = db.Database.SqlQuery<viewModel>("delete from HMS_Doctor where docID = " + id).ToList();

            }

            return Json("", JsonRequestBehavior.AllowGet);

        }


        public ActionResult EditPage()
        {
            ViewBag.departmentList = new SelectList(db.HMS_Department, "departName", "departName");
            ViewBag.bloodGroup = new SelectList(db.HMS_BloodGroup, "bloodGroup", "bloodGroup");
            return View();
        }
        public ActionResult GetRecordById(int last_segment)
        {

            var data = db.Database.SqlQuery<viewModel>("select * from HMS_Doctor where docID= " + last_segment).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult UpdateRecord(string last_segment,string firstname, string lastname, string email, string password, string designation, string departmentList, string address, string phone, string mobile, string picture, string specialist, string date_of_birth, string sex, string bloodGroup, string status)
        {
            var data = db.Database.SqlQuery<viewModel>("update HMS_Doctor set  FirstName ='" + firstname + "' ,LastName = '" + lastname + "' , Email = '" + email + "', Password = '"+password+ "' , Designation = '" + designation + "' , Department = '" + departmentList + "' , Address = '" + address + "' , Phone = '" + phone + "' , Mobile = '" + mobile + "' , Picture = '" + picture + "' , Specialist = '" + specialist + "'  , DateOfBirth = '" + date_of_birth + "' , Sex = '" + sex + "'  , BloodGroup = '" + bloodGroup + "'  , Status = '" + status + "' where docID = " + last_segment).ToList();

            return Json(data, JsonRequestBehavior.AllowGet);
        }


    }
}