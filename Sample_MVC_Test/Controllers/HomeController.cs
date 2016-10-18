using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_MVC_Test.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            string s = "This is Index Method";
            return s;
        }

        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }
    }
}
