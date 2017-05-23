using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Na tej stronie znajdziesz wszystko to, co mamy do zaoferowania.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Jeli masz jakieś uwagi, pomysły na ulepszenie aplikacji, lub po prostu szukasz pomocy z aplikacją tu znajdziesz nasze dane kontaktowe:";

            return View();
        }
    }
}