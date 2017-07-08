using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestDriveValuePassToAnotherPage.Controllers
{
    public class TestController : Controller
    {
        public ActionResult SetValue()
        {
            return View();
        }

        public ActionResult SetValueInCookiesByJavaScript()
        {
            return View();
        }
        public ActionResult GetValueInCookiesByJavaScript()
        {
            return View();
        }
        // GET: Test
        public ActionResult GetValue(string Value="")
        {
            ViewBag.Value = Value;
            //URL DEMO Passing Through Get Method
            //http://localhost:4385/Test/GetValue?Value=working
            return View();
        }

        public ActionResult SetValueInLocalStorageByHTML5()
        {
            return View();
        }
        public ActionResult GetValueInLocalStorageByHTML5()
        {
            return View();
        }

    }
}