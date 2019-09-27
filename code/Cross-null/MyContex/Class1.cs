using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model_Cross;
namespace MyContex
{
    public class MyContent : DbContext
    {
        public MyContent() : base("Cross")
        {

        }

        public DbSet<Play> Games { get; set; }
        public DbSet<Cell> Cells { get; set; }
    }
}
