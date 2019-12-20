using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cross.Models
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext")
        {

        }

        public DbSet<Play> Games { get; set; }
        public DbSet<Cell> Cells { get; set; }
    }
}