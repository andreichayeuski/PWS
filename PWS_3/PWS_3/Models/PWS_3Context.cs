using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PWS_3.Models
{
    public class PWS_3Context : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}