using Data_Validation_Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Data_Validation_Assignment1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]

        public ActionResult Index(StudentRegistration sm)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = sm.Name;
                ViewBag.Rno = sm.Rno;
                ViewBag.Age = sm.Age;
                ViewBag.DOB = sm.DOB;
                ViewBag.Gender = sm.Gender;
                ViewBag.StudentCourse = sm.StudentCourse;
                ViewBag.Email = sm.Email;
                ViewBag.PhoneNumber = sm.PhoneNumber;
                ViewBag.Ssc = sm.Ssc;
                ViewBag.Hsc = sm.Hsc;
                return View();
            }
            else
            {
                ViewBag.Name = "No Data";
                ViewBag.Rno = "No Data";
                ViewBag.Age = "No Data";
                ViewBag.DOB = "No Data";
                ViewBag.Gender = "No Data";
                ViewBag.StudentCourse = "No Data";
                ViewBag.Course = "No Data";
                ViewBag.Email = "No Data";
                ViewBag.PhoneNumber = "No Data";
                ViewBag.Ssc = "No Data";
                ViewBag.Hsc = "No Data";
                return View();
            }

            /*
            public ActionResult Index(string name,string rno, string age, string dob, string gender, string email,string phone, string ssc, string hsc)
        {

           
            if (ModelState.IsValid)
            {
                ViewBag.Name = name;
                ViewBag.Rno = rno;
                ViewBag.Age = age;
                ViewBag.DOB = dob;
                ViewBag.Gender = gender;
                ViewBag.Email = email;
                ViewBag.PhoneNumber = phone;
                ViewBag.Ssc = ssc;
                ViewBag.Hsc = hsc;
                return View();
            }
            else
            {

                ViewBag.Name = "No Data";
                ViewBag.Rno = "No Data";
                ViewBag.Age = "No Data";
                ViewBag.DOB = "No Data";
                ViewBag.Gender = "No Data";
                ViewBag.Course = "No Data";
                ViewBag.Email = "No Data";
                ViewBag.PhoneNumber = "No Data";
                ViewBag.Ssc = "No Data";
                ViewBag.Hsc = "No Data";
                return View();
            }*/
        }

        
    }
}