using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagement1.Data;
using SchoolManagement1.Models;
using System.Collections.Generic;

namespace SchoolManagement1.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        //[Route("Student/Index")]
        public IActionResult Index()
        {
            var List = _context.Students.ToList();

            return View(List);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var courses = _context.Courses.ToList();

            ViewBag.CourseList = new SelectList(courses, "CourseId", "CourseName"); 

            return View();
        }


        [HttpPost]
        public IActionResult Create(Student student,string fName, string lName, string email, string phone, string address, string gender, string hobbies)
        {
            string selectedCourseId = student.CourseId;
            ViewBag.CourseList = selectedCourseId;
         
            try
            {
                var FormData = new Student
                {
                    FName = fName,
                    LName = lName,
                    Email = email,
                    Phone = phone,
                    Address = address,
                    Gender = gender,
                    Hobbies = hobbies,
                    CourseId = student.CourseId
                };

                _context.Students.Add(FormData);
                _context.SaveChanges();


                return RedirectToAction("Index", "Student");

            }
            catch (Exception ex)
            {
               
                return Json(new { Status = "Error", Message = ex.Message });
            }
        }
        public IActionResult Edit(int Id)
        {
            var E = _context.Students.Find(Id);
            var viewModel = new SchoolViewModel();
            
            return View(viewModel);
        }


    }
}














