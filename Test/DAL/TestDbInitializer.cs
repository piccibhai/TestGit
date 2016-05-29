using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Test.Models;

namespace Test.DAL
{
    public class TestDbInitializer:DropCreateDatabaseIfModelChanges<TestDbContext>
    {
        protected override void Seed(TestDbContext context)
        {
            TestDb tdb = new TestDb();
            tdb.name = "mowazzem";
            context.Tests.Add(tdb);
            context.SaveChanges();
        }
    }
}