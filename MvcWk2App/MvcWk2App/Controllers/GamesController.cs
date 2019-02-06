using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWk2App.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public ActionResult Games()
        {
            return View();
        }
    }
}