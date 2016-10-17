using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_MVC_Test.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        public string List()
        {
            return "You are in list method of the process conntroller";
        }
    }
}