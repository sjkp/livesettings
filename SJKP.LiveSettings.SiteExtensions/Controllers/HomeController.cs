using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SJKP.LiveSettings.SiteExtensions.Controllers
{
    public class HomeController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {

            var items = ConfigurationManager.AppSettings.AllKeys.Select(s => $"<add key=\"{s}\" value=\"{ConfigurationManager.AppSettings[s]}\"/>");
            ViewBag.AppSettings = $"<appSettings>\\n  {string.Join("\\n  ", items)}\\n</appSettings>";
            return View();
        }
    }
}