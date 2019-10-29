using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestCore3;

namespace TestCore3.Models
{
    public class TestCore3Context : DbContext
    {
        public TestCore3Context (DbContextOptions<TestCore3Context> options)
            : base(options)
        {
        }

        public DbSet<TestCore3.Model> Model { get; set; }
        public DbSet<TestCore3.SomeOtherModel> someOtherModels { get; set; }
    }
}
