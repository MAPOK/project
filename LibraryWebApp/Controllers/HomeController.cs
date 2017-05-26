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
            ViewBag.Message = "Jesli nie znalazłeś tego co szukałeś - przekaż nam informcaje o autorze i tytule. Postaramy się uzupełnić naszą bazę o tą pozycję.";

            return View();
        }
        [HttpPost]
        public ActionResult About(string message)
        {
            //TODO : send message to LibraryApp
            ViewBag.Message = "Dziękujemy za zgłoszenie. Postaramy się jak najszybciej uzupełnić naszą bibliotekę.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Jeli masz jakieś uwagi, pomysły na ulepszenie aplikacji, lub po prostu szukasz pomocy z aplikacją tu znajdziesz nasze dane kontaktowe:";

            return View();
        }
    }
}