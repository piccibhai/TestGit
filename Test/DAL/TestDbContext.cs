using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Test.Models;

namespace Test.DAL
{
    public class TestDbContext:DbContext
    {
        public TestDbContext() : base("TestDbContext")
        {
        }
        public virtual DbSet<TestDb> Tests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
        }
    }
}