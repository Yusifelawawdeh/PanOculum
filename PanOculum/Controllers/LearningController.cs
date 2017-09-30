using System;
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

            ViewBag.LearnWhat = "Asp.net MVC";
            ViewBag.LearnWhen = "Learning it now";
            ViewBag.LearnHow = "with treeHouse";
            ViewBag.Curriculum = new string[]
                {
                    "C#",
                    "JavaScript",
                    "Python",
                    "SQL"
                };

            return View();
            
        }
    }
}