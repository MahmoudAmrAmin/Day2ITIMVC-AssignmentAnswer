using Day2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Schema;

namespace Day2.Controllers
{
    public class InstructorController : Controller
    {

        CoursesCenterContext courseCenterContext = new();

        // Instructor/Index
        public IActionResult Index()
        {


            List<Instructor> intstructorModel = courseCenterContext.Instructors.Include(co =>co.Course)
                .Include(dep =>dep.Department).ToList();
                            

            return View("Index" , intstructorModel);
        }


        // /Instructor/Details
        public IActionResult Details (int ? id )
        {
            Instructor InstructorModel = courseCenterContext.Instructors
                .Include(co =>co.Course).Include(dep =>dep.Department).FirstOrDefault(inst => inst.Id == id);




            return View("DetailsById", InstructorModel); 

        }
    }
}
 