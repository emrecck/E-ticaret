using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_ticaret_İleri_Seviye_.Models;

namespace E_ticaret_İleri_Seviye_.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(_context.Courses.ToList());
        }
        public ActionResult Details(int id)
        {
            var course = _context.Courses.Find(id);
            return View(course);
        }
        public ActionResult List(int? id)
        {
            var course = _context.Courses.AsQueryable();
            if( id != null )
            {
                course = course.Where(i => i.CategoryId == id);
            }
            return View(course.ToList());
        }
        public PartialViewResult Categories() 
        {
            return PartialView(_context.Categories.ToList());
        }
        public PartialViewResult CourseList() 
        {
            return PartialView(_context.Courses.ToList());
        }
    }
}