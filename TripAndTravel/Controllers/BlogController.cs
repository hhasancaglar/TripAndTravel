﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripAndTravel.Models;

namespace TripAndTravel.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        public ActionResult Index()
        {
            var bloglar = c.Blogs.OrderByDescending(x => x.ID).ToList();
            return View(bloglar);
        }

        public ActionResult BlogDetay(int id)
        {
            var blogBul = c.Blogs.Where(x => x.ID == id).ToList();
            return View(blogBul);
        }
    }
}