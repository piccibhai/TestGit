using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.DAL;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private TestDbContext cxt = new TestDbContext();

        public ActionResult Index()
        {
            
            TestDb tdb = new TestDb();
            tdb.name = "piccibhai";
            cxt.Tests.Add(tdb);
            cxt.SaveChanges();
            return View(tdb);
        }

    }
}
