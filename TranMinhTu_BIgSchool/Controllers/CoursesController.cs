using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TranMinhTu_BIgSchool.Models;
using TranMinhTu_BIgSchool.ViewModels;

namespace TranMinhTu_BIgSchool.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        // GET: Courses
        public CoursesController(){
            _dbContext = new ApplicationDbContext();
        }
        //get
        [Authorize]
        public ActionResult Create()
        {
            var ViewModel = new CourseViewModel
            {
                Categories = _dbContext.categories.ToList()
            };
            return View(ViewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Categories = _dbContext.categories.ToList();
                return View("Create", viewModel);
            }
            var course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                CategoryId = viewModel.Category,
                Place = viewModel.Place
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}