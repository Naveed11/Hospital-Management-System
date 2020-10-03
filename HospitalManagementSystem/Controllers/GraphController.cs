using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagementSystem.Controllers
{
    public class GraphController : Controller
    {
        NaveedEntities db = new NaveedEntities();
        // GET: Graph
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BarChart()
        {
            var list = db.Database.SqlQuery<HMS_Department>("select * from HMS_Department").ToList();

            return Json(list, JsonRequestBehavior.AllowGet);
        }

    }
}