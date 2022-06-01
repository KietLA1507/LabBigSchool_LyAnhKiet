using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LabBigSchool_LyAnhKiet.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        // Them domain class Course va Category
        // ko DBset 2 thang duoi thi add-migration ko ra table dc
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}