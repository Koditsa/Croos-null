using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cross.Models;
using Model_Cross;
using MyContex;

namespace Cross.Controllers
{
    public class HomeController : Controller
    {
        MyContext db = new MyContext();

        public ActionResult Index(string suggest = "")
        {
            // получаем из бд все объекты Book
            IEnumerable<Models.Play> games = db.Games;
            //IEnumerable<Models.Cell> cells = db.Cells;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Games = games;
            //ViewBag.Cells = cells;
            // возвращаем представление
            return View();
        }

        public bool AddWinnerToBd(string suggest = "")
        {
            Models.Play play = new Models.Play();
            play.suggest = suggest;
            db.Games.Add(play);
            db.SaveChanges();
            return true;
        }

    }
}