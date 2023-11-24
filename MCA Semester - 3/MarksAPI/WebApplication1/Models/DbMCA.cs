using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DbMCA : DbContext
    {
        public DbMCA() : base("dbconnection")
        {
        }
        public DbSet<Marks_Master> marks_Masters { get; set; }
        public DbSet<Subject_Master> subject_Masters { get; set; }

    }
}