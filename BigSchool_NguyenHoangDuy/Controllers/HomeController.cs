﻿using BigSchool_NguyenHoangDuy.Models;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Linq;

namespace BigSchool_NguyenHoangDuy.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbcontext;
        public HomeController()
        {
            _dbcontext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            List<Course> upcommingCourses = _dbcontext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.category)  
                .Where(c => c.DateTime > DateTime.Now).ToList();
            return View(upcommingCourses);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}