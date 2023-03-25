using pass_data_controler_to_view.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pass_data_controler_to_view.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string UsingPerameter(string fname, string lname)
        {

            return "From perameter -" + fname + " " + lname;
        }

        [HttpPost]
        public string UsingRequest()
        {
            string fname = Request["fname"];
            string lname = Request["lname"];
            return "From Request -" + fname + " " + lname;
        }
        [HttpPost]
        public string UsingFormcollectoin(FormCollection form)
        {
            string fname = form["fname"];
            string lname = form["lname"];

            return "From Request -" + fname + " " + lname;
        }
        [HttpPost]
        public string Usingmodel(Data data)
        {
            return "From Request -" + data.fname + " " + data.lname;
        }
    }
}