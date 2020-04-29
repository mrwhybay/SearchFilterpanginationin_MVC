using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Temp.Models;

namespace Temp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index(string Sorting_Order, string Search_Data, string Filter_Value, int? Page_No)
      {
            using (var db = new Model2())
            {




                ViewBag.CurrentSortOrder = Sorting_Order;
                ViewBag.SortingName = String.IsNullOrEmpty(Sorting_Order) ? "Name_Description" : "";
                ViewBag.SortingDate = Sorting_Order == "Date_Enroll" ? "Date_Description" : "Date";
                if (Search_Data != null)
                {
                    Page_No = 1;
                }
                else
                {
                    Search_Data = Filter_Value;
                }
                ViewBag.FilterValue = Search_Data;
                var students = from stu in db.Students select stu;

                if (!String.IsNullOrEmpty(Search_Data))
                {
                    students = students.Where(stu => stu.FIrstName.ToUpper().Contains(Search_Data.ToUpper())
                        || stu.LastName.ToUpper().Contains(Search_Data.ToUpper()));
                }


                switch (Sorting_Order)
                {
                    case "Name_Description":
                        students = students.OrderByDescending(stu => stu.FIrstName);
                        break;
                    case "Date_Enroll":
                        students = students.OrderBy(stu => stu.EnrollmentDate);
                        break;
                    case "Date_Description":
                        students = students.OrderByDescending(stu => stu.EnrollmentDate);
                        break;
                    default:
                        students = students.OrderBy(stu => stu.FIrstName);
                        break;
                }
                int Size_Of_Page = 3;
                int No_Of_Page = (Page_No ?? 1);
                return View(students.ToPagedList(No_Of_Page, Size_Of_Page));

            }


        }
        public ActionResult SecondExample()
        {
            return View();
        }
        [HttpGet]
        public JsonResult EmpDetails()
        {
            //Creating List      
            using (var db = new Model2())
            {
                return Json(db.Employees.ToList(), JsonRequestBehavior.AllowGet);
            }
        }


        [HttpGet]
        public ActionResult Addtion()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Addtion( addtion addtion , string Opration )
        {

            var type = Type.GetType(Opration);
            var myObject = (ICalculation)Activator.CreateInstance(type);
            
            myObject.a = addtion.a;
            myObject.b = addtion.b;
            //Opration.
            (myObject ).calculate();

            ViewBag.TotalValue = myObject.Result;
            
            return View(addtion);
        }
    }
}