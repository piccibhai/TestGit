using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Test.DAL;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private TestDbContext cxt;

        public HomeController()
        {
            cxt=new TestDbContext();
        }

        public ActionResult Index()
        {
            
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(TestDb tdb)
        {
            cxt.Tests.Add(tdb);
            cxt.SaveChanges();
            return View();
        }


    }
}
