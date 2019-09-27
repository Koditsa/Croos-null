using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model_Cross;
using MyContex;

namespace Cross.Controllers
{
    public class HomeController : Controller
    {

        
        public ActionResult Index()
        {
            MyContent myContent = new MyContent();
            myContent.Games.Add(new Play());
            myContent.SaveChanges();

            return View();
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