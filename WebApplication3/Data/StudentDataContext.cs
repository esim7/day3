using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class StudentDataContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

        public StudentDataContext() : base("name=StudentConnectionString")
        {
            Database.CreateIfNotExists();
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}