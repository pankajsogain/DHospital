using DHospital.Models;
using DHospital.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DHospital.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DoctorsList(int id)
        {
            Doctor_Context doctor_Context = new Doctor_Context();
            Doctors doc_list= doctor_Context.Doctors.Single(doc => doc.Id == id);
            return View();
        }
    }
}