﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PanOculum.Controllers
{
    public class LearningController : Controller
    {
        // GET: Learning
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                return Redirect("/");
            }
            else
            {
                return Content("Well hello there ");
            }

            
        }
    }
}