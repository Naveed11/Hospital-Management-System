using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagementSystem.Controllers
{
    public class PatientController : Controller
    {
        NaveedEntities db = new NaveedEntities();

        // GET: Patient
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddPatient()
        {
            ViewBag.bloodGroup = new SelectList(db.HMS_BloodGroup, "bloodGroup", "bloodGroup");
            return View();
        }
        public ActionResult AddPatientRecord(string firstname, string lastname, string email,  string address, string mobile, string picture, string date_of_birth, string sex, string bloodGroup, string status)
        {
            var data = db.Database.SqlQuery<viewModel>("insert into HMS_Patient(FirstName,LastName,Email,Address,BloodGroup,Mobile,Picture,DateOfBirth,Sex,Status)values('" + firstname + "','" + lastname + "','" + email + "','" + address + "','"+bloodGroup+"','" + mobile + "','" + picture + "    ','" + date_of_birth + "','" + sex + "','" + status + "')").ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult updatePatientRecord(int patientID,string firstname,string lastname,string email,string mobile,string bloodGroup,string sex,string date_of_birth,string picture,string address,string status)
        {
            var data = db.Database.SqlQuery<viewModel>("update HMS_Patient set FirstName='"+firstname+ "' , LastName = '"+lastname+ "' , Email='"+email+ "' , Address='"+address+ "' , BloodGroup='"+bloodGroup+ "' , Mobile='"+mobile+ "' , Picture='"+picture+ "' , DateOfBirth='"+date_of_birth+ "' , Sex='"+sex+ "',Status='"+status+ "' where patientID = "+patientID).ToList();
            return Json("", JsonRequestBehavior.AllowGet);
        }
        public ActionResult PatientList()
        {
            return View();
        }
        public ActionResult PatientListAll()
        {
            var list = db.Database.SqlQuery<HMS_Patient>("select * from HMS_Patient").ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetPatientRecordById(int patientID)
        {

            var data = db.Database.SqlQuery<HMS_Patient>("select * from HMS_Patient where patientID= " + patientID).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }


        public ActionResult PatientEditPage()
        {
            ViewBag.bloodGroup = new SelectList(db.HMS_BloodGroup, "bloodGroup", "bloodGroup");
            return View();
        }
        public ActionResult PatientDeleteRecord(int patientID)
        {
            var data = db.Database.SqlQuery<HMS_Patient_Delete>("delete from HMS_Patient where patientID="+ patientID).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult AddDocument()
        {
            
            ViewBag.patientName = new SelectList(db.HMS_Patient, "FirstName", "FirstName");
            ViewBag.doctorName = new SelectList(db.HMS_Doctor, "FirstName", "FirstName");
            return View();
        }
        public ActionResult DocumentList()
        {
            return View();
        }

        public ActionResult addPatientDocumentRecord(string txttaskDate,string filenameVariable,string filetypeVariable,string patientName,string imageUploading, string doctorName,string textArea)
        {
            var data = db.Database.SqlQuery<HMS_Document>("insert into HMS_Document(patientName,fileattachment,filename,filetype,doctorName,description,date) values('" + patientName+"','"+imageUploading+"','"+filenameVariable+"','"+filetypeVariable+"','"+doctorName+"', '"+textArea+"','"+txttaskDate+"')").ToList();
            return Json("", JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetDocumentList()
        {
            var data = db.Database.SqlQuery<viewModel>("select documentID, patientName ,doctorName,dateOfTime,description from HMS_Document").ToList();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DocumentEditPage()
        {
            ViewBag.patientName = new SelectList(db.HMS_Patient, "FirstName", "FirstName");
            ViewBag.doctorName = new SelectList(db.HMS_Doctor, "FirstName", "FirstName");
            return View();
        }
        public ActionResult GetDocumentListByID(int last_segment)
        {
            var data = db.Database.SqlQuery<viewModel>("select documentID, patientName ,doctorName,dateOfTime,description from HMS_Document where documentID="+last_segment).ToList();

            return Json(data, JsonRequestBehavior.AllowGet);

        }

        public ActionResult UpdateDocumentRecord(int last_segment,string filetypeVariable,string filenameVariable,string patientName,string imageUploading,string doctorName,string textArea)
        {
            var data = db.Database.SqlQuery<viewModel>("update HMS_Document set patientName = '" + patientName + "' , fileattachment='" + imageUploading + "', filename='" + filenameVariable + "',filetype='" + filetypeVariable + "' , doctorName='" + doctorName + "',description='" + textArea + "' where documentID=" + last_segment).ToList();
            return Json("", JsonRequestBehavior.AllowGet);
            
        }

       public ActionResult DocumentDeleteRecord(int documentID)
        {
            var data = db.Database.SqlQuery<HMS_Document_Delete>("delete from HMS_Document where documentID="+ documentID).ToList();
            return Json(data,JsonRequestBehavior.AllowGet);
        }
           
       
    }
}