using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DHospital.Models;
using DHospital.ViewModel;

namespace DHospital.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Index( int Id)
        {
            try
            {
                Doctor_Context doctor_Context = new Doctor_Context();
                Doctors doctors = doctor_Context.GetDoctors.Where(x => x.Id == Id).FirstOrDefault();
                return View(doctors);
            }
            catch(Exception ex)
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult EditProfile(int Id)
        {
            try
            {
                Doctor_Context doctor_Context = new Doctor_Context();
                Doctors doctors = doctor_Context.GetDoctors.Where(x => x.Id == Id).FirstOrDefault();
                return View(doctors);
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult EditProfile(Doctors docPostValue)
        {
            try
            {
                Doctor_Context doctor_Context = new Doctor_Context();
                Doctors doctors = doctor_Context.GetDoctors.Where(x => x.Id == docPostValue.Id).FirstOrDefault();
                byte[] imageData = null;
                if (Request.Files.Count > 0)
                {
                    HttpPostedFileBase poImgFile = Request.Files["ImageData"];
                    using (var binary = new BinaryReader(poImgFile.InputStream))
                    {
                        imageData = binary.ReadBytes(poImgFile.ContentLength);
                    }
                }
                doctors.Doctor_FullName = docPostValue.Doctor_FullName;
                doctors.UIN = docPostValue.UIN;
                doctors.YOE = docPostValue.YOE;
                doctors.Date_of_Birth = docPostValue.Date_of_Birth;
                doctors.Gendar = docPostValue.Gendar;
                doctors.profile_photo = imageData;
                doctor_Context.SaveChanges();
                return View(doctors);
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        public FileContentResult UserPhotos(int id)
        {
            Doctor_Context doctor_Context = new Doctor_Context();
            Doctors doctors = doctor_Context.GetDoctors.Where(x => x.Id == id).FirstOrDefault();

            // to get the user details to load user Image
            return new FileContentResult(doctors.profile_photo, "image/jpeg");
        }
    }
}