using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DemoMVCApp
{
    public class DemoMVCAppContext : DbContext
    {

        public DemoMVCAppContext()
            : base("DemoMVCAppContext")
        {
        }

        public DbSet<MyApplication> MyApplications { get; set; }
        public DbSet<MyTestTable> MyTestTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}